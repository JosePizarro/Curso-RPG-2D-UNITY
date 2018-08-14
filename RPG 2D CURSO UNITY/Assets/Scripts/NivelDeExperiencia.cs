using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelDeExperiencia : MonoBehaviour {

    private int experienciaActual;
    private int expSiguienteNivel; //experiencia necesaria para subir al siguiente nivel
    private float razonExpNivelActual; //Será el % de experiencia para subir de nivel
    private int nivel { get; set; }

    public int experiencia { get; set; }



	// Use this for initialization
	void Start () {
		
	}
	
	private int CurvaExperiencia(int nivel)
    {
        return nivel;
    }

    private int CurvaExperienciaAcumulativa(int nivel)
    {
        return nivel;
    }

    private void LevelUp()
    {

    }

    void ConfigurarSiguienteNivel()
    {

    }
}
