using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Salud : MonoBehaviour {

    public int saludBase;
    public int salud { get { return saludBase + ModificadorSalud; } }
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
            if (value>0 && value<=salud)
            {
                saludActual = value;
            }
            else if (value>salud)
            {
                saludActual = salud;
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
        SaludActual = salud;
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

    public void ActualizarBarraDeSalud()
    {
        if (barraDeSalud)
        {
            barraDeSalud.fillAmount = (float)SaludActual / salud;
        }
    }

    public void ModificarSaludBase(int cantidad)
    {
        saludBase += cantidad;
        ActualizarBarraDeSalud();
    }
}
