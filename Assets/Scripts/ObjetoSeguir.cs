using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoSeguir : MonoBehaviour {

    public Rigidbody2D objetoReferencia; // Objeto que se usara como referencia para la posicion en el eje X de la camara

    private void FixedUpdate()
    {

        objetoReferencia.velocity = new Vector2(Jugador.instaciaCompartida.jugadorR.velocity.x, objetoReferencia.velocity.y);

    }

}
