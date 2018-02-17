using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
    float time=0; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
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
