using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelDeExperiencia : MonoBehaviour {

    private int experienciaActual;
    private int expSiguienteNivel; //experiencia necesaria para subir al siguiente nivel
    private float razonExpNivelActual; //Será el % de experiencia para subir de nivel
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
                    while (razonExpNivelActual >= 1)
                    {
                        LevelUp();
                    }
                }
            }
            else
            {
                razonExpNivelActual = (float)(experienciaActual) / expSiguienteNivel;

                while (razonExpNivelActual >= 1)
                {
                    LevelUp();
                }
            }
            ActualizarBarraDeExp();
        }
    }



    // Use this for initialization
    void Start() {

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

    }

    void ConfigurarSiguienteNivel()
    {

    }

    void ActualizarBarraDeExp()
    {

    }
}
