using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

    public GameObject objetoSeguir; // Objeto al que seguirá la cámara

    public float desplazarX = 0; // Desplaza la cámara en el eje X. Velor 0 por defecto para pruebas
    public float desplazarY = 0; // Desplaza la cámara en el eje Y. Velor 0 por defecto para pruebas

    private void FixedUpdate()
    {

        transform.position = new Vector3(objetoSeguir.transform.position.x + desplazarX, objetoSeguir.transform.position.y + desplazarY, transform.position.z);

    }

}
