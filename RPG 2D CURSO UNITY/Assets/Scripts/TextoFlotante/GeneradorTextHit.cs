using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorTextHit : MonoBehaviour {

    public TextHit textoHit;
    public Rango rangoXDefault;
    public Rango rangoYDefault;

    private void Start()
    {
        rangoXDefault.min = -1;
        rangoXDefault.max = 1;
        rangoYDefault.min = -1;
        rangoYDefault.max = 1;
    }


    public void CrearTextoHit(TextHit textHit, string contenido, Transform parent,
        float tamanio, Color color, Rango rangoX, Rango rangoY, float tiempoDeVida)
    {
        Vector3 desfase = new Vector2(Random.Range(rangoX.min, rangoX.max), Random.Range(rangoY.min, rangoY.max));
        TextHit nuevoTextHit = Instantiate(textHit, parent.position+desfase, Quaternion.identity, parent);
        nuevoTextHit.tiempoDeVida = tiempoDeVida;
        nuevoTextHit.textMesh.color = color;
        nuevoTextHit.textMesh.characterSize = tamanio;
        nuevoTextHit.textMesh.text = contenido;
    }

    public void CrearTextoHit(TextHit textHit, float contenido, Transform transform, float tamanio,
        Color color, Rango rangoX, Rango rangoY, float tiempoDeVida)
    {
        string contenidoString = contenido.ToString();
        CrearTextoHit(textHit, contenidoString, transform, tamanio, color, rangoX, rangoY, tiempoDeVida);
    }

    public void CrearTextoHit(string contenido)
    {
        Debug.Log("Hola estoy creando un textoHit");
    }
}
