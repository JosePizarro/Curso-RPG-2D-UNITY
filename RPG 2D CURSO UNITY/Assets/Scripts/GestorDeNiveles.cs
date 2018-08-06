using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorDeNiveles : MonoBehaviour {

	public void CargarSiguienteNivel()
    {
      int escenaActualIndice =  SceneManager.GetActiveScene().buildIndex;
      int siguienteEscenaIndice = ++escenaActualIndice; //si ++ está a la derecha de la variable entonces primero se utilizará la variable y luego se le sumará 1, si ++ está a la izquierda primero se sumará 1 a la variable y luego se hará uso de esta
      SceneManager.LoadScene(siguienteEscenaIndice);
    }
}
