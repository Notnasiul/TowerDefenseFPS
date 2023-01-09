using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    public float maxSpeed;
    public Vector2 desiredMovement;
    
    private Rigidbody _rigidbody;

    void OnValidate()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 velocity = new Vector3(desiredMovement.x, 0, desiredMovement.y);
        _rigidbody.velocity = velocity * (maxSpeed * Time.fixedDeltaTime);
    }
}
