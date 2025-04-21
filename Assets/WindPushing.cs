using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindPushing : MonoBehaviour
{
    public Vector3 windDirection = Vector3.right;
    public float windStrength = 5f;

    private Rigidbody targetRigidbody;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Block"))
        {
            targetRigidbody = other.GetComponent<Rigidbody>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Block"))
        {
            targetRigidbody = null;
        }
    }

    void FixedUpdate()
    {
        if (targetRigidbody != null)
        {
            targetRigidbody.AddForce(windDirection.normalized * windStrength, ForceMode.Force);
        }
    }
}
