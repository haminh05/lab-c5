using UnityEngine;

public class Conveyor : MonoBehaviour
{
    public float speed = 2f;

    void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.AddForce(Vector3.forward * speed);
        }
    }
}