using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gato : MonoBehaviour {

    public int gatosOtorgar;

    private void OnTriggerEnter2D(Collider2D jugador)
    {

        if (jugador.tag == "Jugador")
        {

            Destroy(gameObject);
            Jugador.instaciaCompartida.GanarGatos(gatosOtorgar);

        }

    }


}
