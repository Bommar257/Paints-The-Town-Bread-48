using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfly_Flying : MonoBehaviour
{
    
    [SerializeField]
    [Tooltip("Just for debugging, adds some velocity during OnEnable")]
    private Vector3 initialVelocity1;

    [SerializeField]
    private float minVelocity1 = 10f;

    private Vector3 lastFrameVelocity1;
    private Rigidbody rb1;

    private void OnEnable()
    {
        rb1 = GetComponent<Rigidbody>();
        rb1.velocity = initialVelocity1;
    }

    private void Update()
    {
        lastFrameVelocity1 = rb1.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Bounce(collision.contacts[0].normal);
    }

    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity1.magnitude - 1;
        var direction = Vector3.Reflect(lastFrameVelocity1.normalized, collisionNormal);

        Debug.Log("Out Direction: " + direction);
        rb1.velocity = direction * Mathf.Max(speed, minVelocity1);
    }

}
