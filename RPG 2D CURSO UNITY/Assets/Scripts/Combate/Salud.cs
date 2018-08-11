using UnityEngine;
using UnityEngine.Events;

public class Salud : MonoBehaviour {

    public int saludBase;
    private int saludActual;
    public UnityEvent OnMorir;
    public int SaludActual
    {
        get
        {
          return saludActual  ;
        }
        set
        {
            if (value>0)
            {
                saludActual = value;
            }
            else
            {
                saludActual = 0;
                Destroy(gameObject); //Destruir no destruye al objeto instantaneamente- Sino que lo destruirá en el siguiente frame
            }
        }
    }

    // Use this for initialization
    void Start () {
        SaludActual = saludBase;
	}
}
