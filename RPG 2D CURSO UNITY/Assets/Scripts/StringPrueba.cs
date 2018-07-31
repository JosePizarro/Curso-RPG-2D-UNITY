using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringPrueba : MonoBehaviour {

    public string nombre;
    public string saludo;


	// Use this for initialization
	void Start () {
        nombre = "Jose";
        saludo = "Hola Señor ";
        string saludar;
        saludar = saludo + nombre; //output= Hola Señor Jose
        saludar = string.Format("wea wea {0} wea {1}", nombre, saludar);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
