using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Salud : MonoBehaviour {

    public int saludBase;
    private int saludActual;
    public Image barraDeSalud;
    public UnityEvent OnMorir;
    public int ModificadorSalud;
    public int SaludActual
    {
        get
        {
          return saludActual  ;
        }
        set
        {
            if (value>0 && value<=saludBase)
            {
                saludActual = value;
            }
            else if (value>saludBase)
            {
                saludActual = saludBase;
            }
            else
            {
                saludActual = 0;
                gameObject.layer = 12;
                if (OnMorir!=null)
                {
                    OnMorir.Invoke();
                }
            }
        }
    }

    // Use this for initialization
    void Start () {
        SaludActual = saludBase;
	}

    public void modificarSaludActual(int cantidad)
    {
        SaludActual += cantidad;
        ActualizarBarraDeSalud();
    }

    private void DestruirGameObject()
    {
        Destroy(gameObject);
    }

    private void ActualizarBarraDeSalud()
    {
        if (barraDeSalud)
        {
            barraDeSalud.fillAmount = (float)SaludActual / saludBase;
        }
    }
}
