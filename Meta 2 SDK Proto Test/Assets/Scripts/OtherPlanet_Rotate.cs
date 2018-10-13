using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherPlanet_Rotate : MonoBehaviour {


    public float PlanetSpeed = 1.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.right * PlanetSpeed * Time.deltaTime);

    }
}
