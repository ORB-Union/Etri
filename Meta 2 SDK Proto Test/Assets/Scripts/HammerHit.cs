using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerHit : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mole")
        {
            Destroy(other.gameObject);
        }

    }
}
