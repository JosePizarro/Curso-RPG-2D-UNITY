using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName =("ObjetosEscriptables/Items/ItemGenerico"))]
public class Item : ScriptableObject {

    public Sprite sprite;
    public string nombre;
    public bool apilable; //Nos indica si el objeto se puede stackear o apilar, por ejemplo objetos consumibles como pociones
    [TextArea(1, 3)]
    public string descripcion;

    public virtual bool UsarItem()
    {
        Debug.Log("Utilizando " + nombre);
        return true;
    }
}
