using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    Vector3 vect; 
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(Input.GetAxis("Horizontal"));
        vect = transform.position;
        vect.x = (Input.GetAxis("Horizontal"));
        transform.position = vect; 

    }
}
