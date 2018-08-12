using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacante : MonoBehaviour {

    public float desfase = 1f;
    public Vector2 hitBox = new Vector2(1, 1);
    private Vector2 vectorDesfaseAtaque;
    private Vector2 puntoA, puntoB;
    public LayerMask layerAtaque;
    private Collider2D[] ataqueColliders = new Collider2D[12];
    private ContactFilter2D filtroDeAtaque;

    private void Start()
    {
        filtroDeAtaque.layerMask = layerAtaque;
        filtroDeAtaque.useLayerMask = true;
    }


    private void Update()
    {
        Debug.DrawLine(transform.position, (Vector2)transform.position + vectorDesfaseAtaque, Color.yellow);
        Debug.DrawLine(puntoA, puntoB, Color.red);
    }


    public void Atacar(Vector2 direccionDeAtaque, int danio)
    {
        CrearHitBox(direccionDeAtaque);
       GameObject objetoAtacado;
       int elementosAtacados=  Physics2D.OverlapArea(puntoA, puntoB,filtroDeAtaque,ataqueColliders);
        Debug.Log("el numero de elementos atacados es"+elementosAtacados);
        for(int i = 0; i < elementosAtacados; i++)
        {
            objetoAtacado = ataqueColliders[i].gameObject;
            if (objetoAtacado.GetComponent<Atacable>())
            {
                objetoAtacado.GetComponent<Atacable>().RecibirAtaque(direccionDeAtaque,danio);
            }
        }
    }

    private void CrearHitBox(Vector2 direccionDeAtaque)
    {
        Vector2 escala = transform.lossyScale; //(2,3)
        Vector2 hitBoxEscalado = Vector2.Scale(hitBox, escala);
        vectorDesfaseAtaque = Vector2.Scale(direccionDeAtaque.normalized * desfase, escala);
        puntoA = (Vector2)transform.position + vectorDesfaseAtaque - hitBoxEscalado * 0.5f;
        puntoB = puntoA + hitBoxEscalado;
    }
}
