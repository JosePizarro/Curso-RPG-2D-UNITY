using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="ObjetosEscriptables/Atributos")]
public class Atributos :ScriptableObject  {

    [Tooltip("Velocidad de movimiento")]
    public int velocidad;
    public int ataque;
    
}
