using System.Collections;
using System.Collections.Generic;
using UnityEngine;  //NameSpace es un conjunto de clases


//Alcance--- //class-->clase //InputPlayer -->Nombre de la clase 
public class InputPlayer : MonoBehaviour {

    //Joystick ejeHorizontal&Vertical -1,1
    public float ejeHorizontal;
    public float ejeVertical;

	// Use this for initialization //Vacío
	void Start () {
        ejeHorizontal = ejeHorizontal + 1;
        ejeHorizontal += 1;
        ejeHorizontal += 3;
        ejeHorizontal++;

        float misEjesSumados = SumarEjes(ejeHorizontal, ejeVertical);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float EntregarEjeHorizontal()
    {
        ejeVertical = 1;
        ejeHorizontal = 1;
        float sumaEjes = 0;
        sumaEjes = ejeVertical + ejeHorizontal;
        return sumaEjes;
    }

    public float SumarEjes(float ejeHorizonta, float ejeVertical)
    {
        float sumaEjes = ejeHorizonta + ejeVertical;
        EntregarEjeHorizontal();
        return sumaEjes; 
    }
}
