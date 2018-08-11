
using UnityEngine;

public class Atacable : MonoBehaviour {

    private Salud miSalud;
    private Rigidbody2D miRigidbody;

    private void Start()
    {
        miRigidbody = GetComponent<Rigidbody2D>();
        miSalud = GetComponent<Salud>();
    }

    public void RecibirAtaque()
    {
        miSalud.SaludActual -= 1;
    }

    public void RecibirAtaque(Vector2 direccionDeAtaque, int danio)
    {
        miSalud.modificarSaludActual(-danio);
        miRigidbody.AddForce(direccionDeAtaque*danio*100);
    }
}
