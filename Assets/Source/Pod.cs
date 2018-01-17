// © Copyright Brandon Gallo 2018. All Rights Reserved.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pod : MonoBehaviour {

	void Start () {
	}

    void Update () {
        /* Moves down 0.2 units every frame.
         * deltaTime (change in time) ensures that the same speed is maintained independent of frame rate.*/
        transform.Translate(0,-0.2f*Time.deltaTime,0); 
	}
    // GOTTA GO FAST!
}
