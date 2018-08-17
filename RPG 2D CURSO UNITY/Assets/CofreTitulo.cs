using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CofreTitulo : MonoBehaviour {

    public Sprite cofreCerrado;
    public Sprite cofreAbierto;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public bool abierto;

	public void AbrirOCerrar()
    {
        if (abierto)
        {
            image.sprite = cofreCerrado;
            abierto = false;
        }
        else
        {
            image.sprite = cofreAbierto;
            abierto = true;
        }
    }
}
