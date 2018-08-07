using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform playerSpawnPoint; //Punto de inicio de mi jugador
    public GameObject jugador;
    
	// Use this for initialization
	void Start () {
        jugador = GameObject.FindGameObjectWithTag("Player");
        jugador.transform.position = playerSpawnPoint.position;
	}
}
