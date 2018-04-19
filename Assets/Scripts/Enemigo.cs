using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    string nombre;
    public int gatosPerder;

    private void OnTriggerEnter2D(Collider2D jugador)
    {
        
        if (jugador.tag == "Jugador")
        {

            Jugador.instaciaCompartida.PerderGatos(gatosPerder);
            Destroy(gameObject);

        }

    }

}
