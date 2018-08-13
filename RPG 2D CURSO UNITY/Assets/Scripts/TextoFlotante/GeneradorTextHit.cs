using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorTextHit : MonoBehaviour {

    public TextHit textoHit;
    public Rango rangoXDefault = new Rango();
    public Rango rangoYDefault = new Rango();
    


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


    public void CrearTextoHit(TextHit textHit, float contenido, Transform transform, float tamanio,
       Color color,  float tiempoDeVida)
    {
        CrearTextoHit(textHit, contenido, transform, tamanio, color, rangoXDefault, rangoYDefault, tiempoDeVida);
    }

    public void CrearTextoHit(string contenido)
    {
        CrearTextoHit(textoHit, contenido, transform, 0.25f, Color.white,rangoXDefault,rangoYDefault, 2f);
    }

    public void CrearTextoHit(float contenido, Transform parent)
    {
        CrearTextoHit(textoHit, contenido , parent, 0.2f, Color.white,rangoXDefault,rangoYDefault, 2f);
    }
}
