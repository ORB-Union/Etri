using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotate : MonoBehaviour {



    public float EarthSpeed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.up * EarthSpeed * Time.deltaTime);
		
	}
}
