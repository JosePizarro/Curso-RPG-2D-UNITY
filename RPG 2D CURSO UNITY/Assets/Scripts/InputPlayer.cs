using System.Collections;
using System.Collections.Generic;
using UnityEngine;  //NameSpace es un conjunto de clases
using UnityEngine.SceneManagement;


//Alcance--- //class-->clase //InputPlayer -->Nombre de la clase 
public class InputPlayer : MonoBehaviour {

    //Joystick ejeHorizontal&Vertical -1,1
    
   [HideInInspector] public float ejeHorizontal{ get; private set; } //Por defecto un valor de 0
   [HideInInspector] public float ejeVertical  { get; private set; }
   [HideInInspector] public bool atacar        { get; private set; }
   [HideInInspector] public bool habilidad1   { get; private set; }
   [HideInInspector] public bool habilidad2    { get; private set; }
   [HideInInspector] public bool inventario   { get; private set; }
   [HideInInspector] public bool interactuar   { get; private set; }

    private float variableFloatPrivada;
    public float VariableFloatPrivada
    {
        get
        {
            Debug.Log("Obteniendo mi propiedad VariableFloatPrivada");
            return variableFloatPrivada;
        }
         set
        {
            Debug.Log("Asignando mi valor VariableFloatPrivada a " + value);
            variableFloatPrivada = value; //value es igual al valor que yo le asigne a mi propiedad
        }
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
	}


}
