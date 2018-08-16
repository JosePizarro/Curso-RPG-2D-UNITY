using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasillaEquipamiento : Casilla {

    public Equipo tipoEquipamiento;

    protected override void UsarObjetoEnCasilla()
    {
        DesequiparObjeto();
    }

    private void DesequiparObjeto()
    {
        if (Inventario.instance.inventarioLleno)
        {
            Debug.Log("No me puedod desequipar porque el inventario está lleno");
        }
        else
        {
            Inventario.instance.AgregarObjeto(itemAlmacenado, 1);
            EliminarObjeto();
        }
    }
}
