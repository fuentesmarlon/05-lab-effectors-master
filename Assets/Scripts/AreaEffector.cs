/*Universidad del valle de guatemala
 * Nombre: Marlon Fuentes
 * Laboratorio 5 
 * Manejadro de effectos
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
    float time=0; 


	// Use this for initialization
	void Start () {
		
	}
	
	//Le suma a la variable de tiempo, si es mayor de tanto, apaga al game object
	void Update () {
		time+= Time.deltaTime;
        if (time >= 20f)
        {
            gameObject.SetActive(false);
            
        }
        else
        {
            gameObject.SetActive(true);
        }
        Debug.Log(time);
        
	}
}
