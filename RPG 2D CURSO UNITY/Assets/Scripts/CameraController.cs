using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour {

    private CinemachineVirtualCamera cv;
    public GameObject jugador;

    private void Start()
    {
        cv = GetComponent<CinemachineVirtualCamera>();
        Transform jugador = GameManager.instance.jugador.transform;
        cv.m_Follow = jugador;
    }
}
