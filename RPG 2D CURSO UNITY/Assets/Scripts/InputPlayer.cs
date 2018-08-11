using System.Collections;
using System.Collections.Generic;
using UnityEngine;  //NameSpace es un conjunto de clases
using UnityEngine.SceneManagement;


//Alcance--- //class-->clase //InputPlayer -->Nombre de la clase 
public class InputPlayer : MonoBehaviour {

    //Joystick ejeHorizontal&Vertical -1,1
    
    public float ejeHorizontal{ get; private set; } //Por defecto un valor de 0
    public float ejeVertical  { get; private set; }
    public bool atacar        { get; private set; }
    public bool habilidad1   { get; private set; }
    public bool habilidad2    { get; private set; }
    public bool inventario   { get; private set; }
    public bool interactuar   { get; private set; }

    [HideInInspector]
    public Vector2 direccionMirada = new Vector2(0, -1f);


	// Update is called once per frame
	void Update ()
    {
        // atacar= Input.GetKeyDown(KeyCode.A); //No la recomiendo
        atacar = Input.GetButtonDown("Atacar");
        habilidad1 = Input.GetButtonDown("Habilidad1");
        habilidad2 = Input.GetButtonDown("Habilidad2");
        inventario = Input.GetButtonDown("Inventario");
        interactuar = Input.GetButtonDown("Interactuar");
        //Definir ejes de movimiento
        ejeHorizontal = Input.GetAxis("Horizontal");
        ejeVertical = Input.GetAxis("Vertical");

        DeterminarDireccionMirada();
       // Debug.DrawLine(transform.position, transform.position + (Vector3)direccionMirada.normalized*3,Color.green);
    }

    private void DeterminarDireccionMirada()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            direccionMirada.x = ejeHorizontal;
            direccionMirada.y = ejeVertical;
        }
    }
}
