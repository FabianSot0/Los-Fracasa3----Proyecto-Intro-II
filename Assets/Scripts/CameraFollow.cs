using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject seguir;

    public float correrX = 0;
    public float correrY = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {

        float posicionX = seguir.transform.position.x;
        float posicionY = seguir.transform.position.y;

        transform.position = new Vector3(posicionX + correrX, posicionY + correrY, transform.position.z);

    }
}
