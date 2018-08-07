using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactivo : MonoBehaviour {

    private Collider2D micolisionador;
    public UnityEvent OnInteraccion;
    

    private void Start()
    {
        micolisionador = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnInteraccion.Invoke();
    }
}
