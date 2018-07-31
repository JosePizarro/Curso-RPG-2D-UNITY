using System.Collections;
using System.Collections.Generic;
using UnityEngine;  //NameSpace es un conjunto de clases


//Alcance--- //class-->clase //InputPlayer -->Nombre de la clase 
public class InputPlayer : MonoBehaviour {

    //Joystick ejeHorizontal&Vertical -1,1
    public float ejeHorizontal; //Por defecto un valor de 0
    public float ejeVertical;
    public bool atacar; //Bool verdadero o falso
    public bool habilidad1;
    public bool habilidad2;
    public bool inventario;
    public bool interactuar;


	// Use this for initialization //Vacío
	void Start () {
       

	}
	
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
        Debug.Log("El eje horizontal es " + ejeHorizontal + " El eje vertical es " + ejeVertical);
	}

}
