using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab6 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision with: " + collision.gameObject.name);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger with: " + other.name);
    }
}
