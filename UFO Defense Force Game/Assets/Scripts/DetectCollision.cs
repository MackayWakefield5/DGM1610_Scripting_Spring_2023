using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Destroy this gameobject
        Destroy(gameObject);

        // Destroy hit gameObject
        Destroy(other.gameObject);
    }
}
