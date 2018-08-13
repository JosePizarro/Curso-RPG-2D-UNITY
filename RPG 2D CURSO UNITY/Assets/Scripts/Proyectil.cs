using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
public class Proyectil : MonoBehaviour {

    public float velocidadInicial;
    public Vector2 direccionInicial;
    public int danio;
    private Rigidbody2D miRigidbody2d;
    public string tagObjetivo;

	// Use this for initialization
	void Start () {
        miRigidbody2d = GetComponent<Rigidbody2D>();
        miRigidbody2d.velocity = direccionInicial.normalized * velocidadInicial;
        Destroy(gameObject,5f);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(tagObjetivo))
        {
            collision.gameObject.GetComponent<Atacable>().RecibirAtaque(direccionInicial, danio);
            Destroy(gameObject);
        }
    }
}
