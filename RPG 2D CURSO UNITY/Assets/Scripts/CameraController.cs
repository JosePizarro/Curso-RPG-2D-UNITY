using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform jugador;
    private Transform mitransformada;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        float posX = jugador.position.x;
        float posY = jugador.position.y;
        MoverCamara(posX, posY);
	}

    void MoverCamara(float coordenadaX, float coordenadaY)
    {
        Vector3 nuevaPosicion = new Vector3(coordenadaX, coordenadaY, transform.position.z);
       // transform.position = nuevaPosicion;
        Camera.main.transform.position = nuevaPosicion;
    }

}
