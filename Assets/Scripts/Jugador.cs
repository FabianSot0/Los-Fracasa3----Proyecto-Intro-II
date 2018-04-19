using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {

    // Variables y listas --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public int cantidadGatos; // Indica la cantidad de gatos que posee un objeto de clase Jugador
    public float velocidadMaxima;  // Indica la velocidad maxima a la cual puede ir un objeto de clase Jugador
    public float fuerzaSalto; // Indica la fuerza con la cual salta un objeto de clase Jugador
    public float largoAncho; // Indica las dimensiones de un objeto de la clase jugador. Al tratarse de un objeto con forma esferica x = y

    public float radioComprobadorSalto; // Es un radio imaginario que se proyecta desde el punto central de un objeto de clase Jugador. Este radio comprueba si el objeto esta tocando la superficie de un nivel para permitirle saltar

    public GameObject jugadorG; // Permite acceder a las propiedades de GameObject de un objeto de clase Jugador
    public Rigidbody2D jugadorR; // Permite acceder a las propiedades fisicas de un objeto de clase Jugador
    public static Jugador instaciaCompartida; // Plantea la existencia de un solo objeto de clase Jugador al mismo tiempo, permitiendo ademas accedar a sus variables, listas y subprogramas
    public LayerMask suelo; // Declara la existencia de una mascara suelo que debe ser asigana externamente en el inspector de Unity

    // 
    private void Awake()
    {

        jugadorR = GetComponent<Rigidbody2D>();
        instaciaCompartida = this;

    }

    //
    private void FixedUpdate()
    {

        // Dimension(largoAncho, cantidadGatos, radioComprobadorSalto); // Activar para probar y calibrar el subprograma
        Velocidad(velocidadMaxima);

    }

    // Update is called once per frame
    void Update ()
    {

        Saltar(fuerzaSalto, radioComprobadorSalto);

	}

    // Subprograma que controla la velocidad a la cual puede ir un objeto de clase Jugador
    void Velocidad (float velocidadMaxima)
    {

        jugadorR.velocity = new Vector2((Mathf.Clamp(jugadorR.velocity.x, 0.1f, velocidadMaxima)), jugadorR.velocity.y);

    }

    // Subprograma que le permite saltar a un objeto de la clase Jugador
    void Saltar(float fuerzaSalto, float radioComprobadorSalto)
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics2D.OverlapCircle(jugadorR.position, radioComprobadorSalto, suelo))
            {

                jugadorR.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);

            }

        }

    }

    // Subprograma que controla la ganancia de gatos para un objeto de la clase Jugador
    public void GanarGatos (int gatosGanar)
    {

        this.cantidadGatos += gatosGanar;

    }

    // Subprograma que controla la perdida de gatos para un objeto de la clase Jugador
    public void PerderGatos (int gatosPerder)
    {

        this.cantidadGatos -= gatosPerder;

    }

    // Subprograma que controla las dimensiones de un objeto de la clase Jugador
    public void Dimension(float largoAncho, int cantidadGatos, float radioComprobadorSalto) 
    {

        if (cantidadGatos > 3)
        {

            jugadorR.transform.localScale = new Vector3(largoAncho + (cantidadGatos * 0.1f), largoAncho + (cantidadGatos * 0.1f));
            radioComprobadorSalto += cantidadGatos * 0.1f;

        }
        else
        {

            jugadorR.transform.localScale = new Vector3(largoAncho, largoAncho);
            radioComprobadorSalto = largoAncho + 0.1f;

        }

    }
}
