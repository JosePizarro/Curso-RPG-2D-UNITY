using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Casilla : MonoBehaviour,IPointerDownHandler {

    public int cantidadStock;
    public Item itemAlmacenado;
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }


    // Use this for initialization
    void Start () {
        if (itemAlmacenado==null)
        {
            image.enabled = false;
        }
	}
	
	public void AgregarObjeto(Item item, int cantidad)
    {
        itemAlmacenado = item;
        image.enabled = true;
        image.sprite = item.sprite;
        cantidadStock = cantidad;
    }

    public void EliminarObjeto()
    {
        image.sprite = null;
        cantidadStock = 0;
        image.enabled = false;
        itemAlmacenado = null;
    }

    protected virtual void UsarObjetoEnCasilla()
    {
        if (itemAlmacenado)
        {
            if (itemAlmacenado.UsarItem())
            {
                cantidadStock--;
            }
        }
    }

    private void ReducirStock(int cantidad)
    {
        cantidadStock -= cantidad;
        if (cantidadStock<=0)
        {
            EliminarObjeto();
        }
    }



    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
