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

        if (Inventario.instance.AgregarObjeto(itemAlmacenado, 1))
        {
            EliminarObjeto();
        }
    }
}
