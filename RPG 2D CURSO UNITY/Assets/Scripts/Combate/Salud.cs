using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour {

    public int saludBase;
    private int saludActual;
    public int SaludActual
    {
        get
        {
          return saludActual  ;
        }
        set
        {
            if (value>0)
            {
                saludActual = value;
            }
            else
            {
                saludActual = 0;
            }
        }
    }

    // Use this for initialization
    void Start () {
        SaludActual = saludBase;
	}
	
	
}
