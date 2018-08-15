using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanelAtributos : MonoBehaviour {

    public static PanelAtributos instance;
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }

    public TextMeshProUGUI txtNivel;
    public TextMeshProUGUI txtExperiencia;
    public TextMeshProUGUI txtSalud;
    public TextMeshProUGUI txtAtaque;
    public TextMeshProUGUI txtVelocidad;
    public TextMeshProUGUI txtPuntosDeAtributos;

	public void ActualizarTextosAtributos(Atributos atributos, Salud salud, NivelDeExperiencia nivelDeExperiencia)
    {
        txtNivel.text = nivelDeExperiencia.nivel.ToString();
        txtExperiencia.text = nivelDeExperiencia.experiencia.ToString();
        txtSalud.text = salud.salud.ToString();
        txtAtaque.text = atributos.ataque.ToString();
        txtVelocidad.text = atributos.velocidad.ToString();
        txtPuntosDeAtributos.text = nivelDeExperiencia.puntosDeAtributos.ToString();
    }

}
