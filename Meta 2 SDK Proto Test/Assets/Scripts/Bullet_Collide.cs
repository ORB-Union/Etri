using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Collide : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            DestroyObject(other.gameObject, 0f);
        }
    }
}
