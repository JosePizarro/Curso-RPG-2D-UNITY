using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform playerSpawnPoint; //Punto de inicio de mi jugador
    public GameObject jugador;
    public static GameManager instance { get; private set; }
    public Transform contenedorDeProyectiles;

    // Use this for initialization

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }
    void Start () {
        jugador = GameObject.FindGameObjectWithTag("Player");
        jugador.transform.position = playerSpawnPoint.position;
	}
}
