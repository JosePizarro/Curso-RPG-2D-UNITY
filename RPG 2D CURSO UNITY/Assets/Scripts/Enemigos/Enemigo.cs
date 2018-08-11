using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    public Atributos atributos;
    public string nombre;
    public int experiencia;

    protected void PresentarseDeFormaCortez() //Protected permite acceder desde clases derivadas pero no desde "afuera"
    {
        Debug.Log("Hola, yo soy " + nombre);
    }
}
