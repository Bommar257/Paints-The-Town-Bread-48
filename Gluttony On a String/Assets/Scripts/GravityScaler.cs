using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScaler : MonoBehaviour
{
    
    public Vector3 gravity;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        gravity = Vector3.up;
    }

    void Update()
    {
        rb.AddForce(gravity, ForceMode.Acceleration);
    }

    void ReverseGravity() => gravity *= -1;
}
