using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacante : MonoBehaviour {

    public float desfase = 1f; //Desfase entre nuestro personaje y el centro de nuestro hitbox
    public Vector2 tamañoHitBox = new Vector2(1f, 1f); //definirá el tamaño de nuestro hitbox
	
    public void Atacar(Vector2 direccionAtaque, int danio)
    {
        Vector2 vectorDesfase = direccionAtaque.normalized * desfase; //Vector normalizado es un vector cuya magnitud es igual a 1, esto significa que solamente trabajaremos con su dirección y la magnitud estará definida por el coeficiente que lo multiplique
        Vector2 puntoA = (Vector2)transform.position + vectorDesfase - tamañoHitBox * 0.5f;
        Vector2 puntoB = (Vector2)transform.position + vectorDesfase;
    }

}
