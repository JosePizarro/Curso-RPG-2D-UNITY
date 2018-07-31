using System.Collections;
using System.Collections.Generic;
using UnityEngine;  //NameSpace es un conjunto de clases


//Alcance--- //class-->clase //InputPlayer -->Nombre de la clase 
public class InputPlayer : MonoBehaviour {

    //Joystick ejeHorizontal&Vertical -1,1
    public float ejeHorizontal; //Por defecto un valor de 0
    public float ejeVertical;
    public bool atacar; //Bool verdadero o falso


	// Use this for initialization //Vacío
	void Start () {
       

	}
	
	// Update is called once per frame
	void Update () {
        // atacar= Input.GetKeyDown(KeyCode.A); //No la recomiendo
        atacar = Input.GetButtonDown("Atacar");
       Debug.Log(atacar);
	}

}
