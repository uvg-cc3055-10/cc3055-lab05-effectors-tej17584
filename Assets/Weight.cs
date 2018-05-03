using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour {
    //VAriables que usaremos
    LineRenderer line;//linea
    DistanceJoint2D distanceJoint;//variable
	// Use this for initialization
	void Start () {
        //Obtenemos los componentes
        distanceJoint = GetComponent<DistanceJoint2D>();
        line = GetComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        //posiciones que tomara el distance joint y el line renderer
        line.SetPosition(0, transform.position);
        //se setea la posicion y se transforma con tres parámetros
        line.SetPosition(1,distanceJoint.connectedBody.transform.position);
    }
}
