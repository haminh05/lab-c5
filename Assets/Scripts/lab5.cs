using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab5 : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * 20, ForceMode.Impulse);
    }
}
