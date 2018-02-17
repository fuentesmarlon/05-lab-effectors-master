/*Universidad del valle de guatemala
 * Nombre: Marlon Fuentes
 * Laboratorio 5 
 * Linea del objeto "weight"
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour {
    //atributos requeridos 
    LineRenderer line;
    DistanceJoint2D distanceJoint;

	// Use this for initialization
	void Start () {
        //obtenemos los componentes
        distanceJoint = GetComponent<DistanceJoint2D>();
        line = GetComponent<LineRenderer>();
	}
	
	// asignamos una posicion de inicio y otra de fin 
	void Update () {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, distanceJoint.connectedBody.transform.position);
	}
}
