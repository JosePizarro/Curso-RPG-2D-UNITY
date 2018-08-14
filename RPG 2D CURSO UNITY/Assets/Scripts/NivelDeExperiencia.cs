using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GeneradorTextHit))]
public class NivelDeExperiencia : MonoBehaviour {

    public Image barraDeExp;
    private GeneradorTextHit generadorText;
    private Rango rangoTextoLevelUp = new Rango() { min = 0, max = 0 };
    private int experienciaActual;
    private int expSiguienteNivel; //experiencia necesaria para subir al siguiente nivel
    private float razonExpNivelActual; //Será el % de experiencia para subir de nivel
    private int puntosDeAtributos;
    private int nivel { get; set; }

    public int experiencia
    {
        get { return experienciaActual; }

        set
        {
            experienciaActual = value; //Subimos de nivel? Cuántos niveles subimos? cuál es mi razón exp/nivel?
            if (nivel > 1)
            {
                razonExpNivelActual = (float)(experiencia - CurvaExperienciaAcumulativa(nivel)) / expSiguienteNivel;
                {
                    RevisarSiSeSubeDeNivel();
                }
            }
            else
            {
                razonExpNivelActual = (float)(experienciaActual) / expSiguienteNivel;

                RevisarSiSeSubeDeNivel();
            }
            ActualizarBarraDeExp();
        }
    }

    private void RevisarSiSeSubeDeNivel()
    {
        while (razonExpNivelActual >= 1)
        {
            LevelUp();
        }
    }



    // Use this for initialization
    void Start() {
        nivel = 1;
        generadorText = GetComponent<GeneradorTextHit>();
        expSiguienteNivel = CurvaExperiencia(nivel);
        ActualizarBarraDeExp();
    }

    private int CurvaExperiencia(int nivel)
    {
        float funcionExperiencia = (Mathf.Log(nivel, 3f) + 20);
        int experiencia = Mathf.CeilToInt(funcionExperiencia);

        return experiencia;
    }

    private int CurvaExperienciaAcumulativa(int nivel)
    {
        int experiencia = 0;
        for (int i = 1; i < nivel; i++)
        {
            experiencia += CurvaExperiencia(i);
        }

        return experiencia;
    }

    private void LevelUp()
    {
        nivel++;
        ConfigurarSiguienteNivel();
        generadorText.CrearTextoHit(generadorText.textoHit, "NUEVO NIVEL!!", transform, 0.4f, Color.cyan,rangoTextoLevelUp,rangoTextoLevelUp, 2f);
        razonExpNivelActual = (float)(experiencia - CurvaExperienciaAcumulativa(nivel)) / expSiguienteNivel;
    }

    void ConfigurarSiguienteNivel()
    {
        puntosDeAtributos++;
        expSiguienteNivel = CurvaExperiencia(nivel);
    }

    void ActualizarBarraDeExp()
    {
        barraDeExp.fillAmount = razonExpNivelActual;
    }
}
