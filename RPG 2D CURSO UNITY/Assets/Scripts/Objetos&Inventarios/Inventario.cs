using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour {

    public bool inventarioLleno;
    public static Inventario instance;
    private Casilla[] casillas;
    private List<Item> objetos = new List<Item>();
    private int casillaVacia = 0;

    private void Awake()
    {
        instance = this;
        casillas = GetComponentsInChildren<Casilla>();
        
    }

    void DeterminarSiguienteCasillaVacia()
    {
        casillaVacia = 0;
        foreach (Casilla casilla in casillas)
        {
            if (casilla.itemAlmacenado)
            {
                casillaVacia++;
            }
        }
        if (casillaVacia>=casillas.Length)
        {
            inventarioLleno = true;
        }
    }

    public bool AgregarObjeto(Item item, int cantidad)
    {
        DeterminarSiguienteCasillaVacia();
        //El inventario está lleno? El objeto a agregar es apilable? Si es apilable, tengo una copia de este en mi inventario?
        if ((item.apilable && !objetos.Contains(item) && !inventarioLleno) || (item.apilable && !inventarioLleno))
        {
            //Agregar un objeto nuevo
        }
        return true;
    }
}
