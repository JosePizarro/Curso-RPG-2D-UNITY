using System.Collections;
using System.Collections.Generic;
using UnityEngine;  //NameSpace es un conjunto de clases


//Alcance--- //class-->clase //InputPlayer -->Nombre de la clase 
public class InputPlayer : MonoBehaviour {

    //Joystick ejeHorizontal&Vertical -1,1
   [HideInInspector] public float ejeHorizontal; //Por defecto un valor de 0
   [HideInInspector] public float ejeVertical;
   [HideInInspector] public bool atacar; //Bool verdadero o falso
   [HideInInspector] public bool habilidad1;
   [HideInInspector] public bool habilidad2;
   [HideInInspector] public bool inventario;
   [HideInInspector] public bool interactuar;


	// Update is called once per frame
	void Update () {
        // atacar= Input.GetKeyDown(KeyCode.A); //No la recomiendo
        atacar = Input.GetButtonDown("Atacar");
        habilidad1 = Input.GetButtonDown("Habilidad1");
        habilidad2 = Input.GetButtonDown("Habilidad2");
        inventario = Input.GetButtonDown("Inventario");
        interactuar = Input.GetButtonDown("Interactuar");

        //Definir ejes de movimiento
        ejeHorizontal = Input.GetAxis("Horizontal");
        ejeVertical = Input.GetAxis("Vertical");
	}
}
