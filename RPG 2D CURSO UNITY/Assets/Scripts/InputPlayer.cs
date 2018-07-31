using System.Collections;
using System.Collections.Generic;
using UnityEngine;  //NameSpace es un conjunto de clases


//Alcance--- //class-->clase //InputPlayer -->Nombre de la clase 
public class InputPlayer : MonoBehaviour {

    //Joystick ejeHorizontal&Vertical -1,1
    public float ejeHorizontal; //Por defecto un valor de 0
    public float ejeVertical;
    private string pruebaDebug = "HOLA MUNDO";

	// Use this for initialization //Vacío
	void Start () {
        ejeHorizontal = ejeHorizontal + 1; //ejeHorizontal=1//
        ejeHorizontal += 1; //ejeHorizontal=2
        ejeHorizontal += 3; //ejeHorizontal=5
        ejeHorizontal++; //ejeHorizontal =6

	}
	
	// Update is called once per frame
	void Update () { 

        Debug.Log(ejeHorizontal);
        Debug.Log("El valor del eje vertical es " +ejeVertical);    //Debug consume muchos recurso, es un problema para el performance 
	}

}
