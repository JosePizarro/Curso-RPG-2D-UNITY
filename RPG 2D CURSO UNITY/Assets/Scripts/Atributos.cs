using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Atributo
{
    velocidad,
    ataque,
    Salud
}

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
    
   public void ModificarAtributo(Atributo atributo, int cantidad)
    {
        switch (atributo)
        {
            case Atributo.velocidad:
                velocidadModificador += cantidad;

                break;
            case Atributo.ataque:
                ataqueModificador += cantidad;
                break;
            case Atributo.Salud:
                break;
            default:
                Debug.Log("Ninguna de las anteriores");
                break;
        }
    }

    private void ModificarSalud(Salud salud,int cantidad)
    {
        salud.ModificadorSalud += cantidad;
    }
}
