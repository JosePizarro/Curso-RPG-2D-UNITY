using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="ObjetosEscriptables/Atributos")]
public class Atributos :ScriptableObject  {

    [Tooltip("Velocidad de movimiento")]

    [SerializeField]
    private int velocidadBase;
    [SerializeField]
    private int ataqueBase;

    private int velocidadModificador;
    private int ataqueModificador;

    public int velocidad { get {return velocidadBase+velocidadModificador ; } }
    public int ataque { get { return ataqueBase + ataqueModificador; }}

    public void AumentarVelocidadBase(int cantidad)
    {
        velocidadBase += cantidad;
    }

    public void AumentarAtaqueBase(int cantidad)
    {
        ataqueBase += cantidad;
    }
    
}
