using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacable : MonoBehaviour {

    private Salud miSalud;

    private void Start()
    {
        miSalud = GetComponent<Salud>();
    }

    public void RecibirAtaque()
    {
        miSalud.SaludActual -= 1;
    }
}
