using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    public float maxSpeed;
    public float rotationSpeed;
    public Vector2 desiredMovement;
    public Vector2 desiredLook;
    
    
    private Rigidbody _rigidbody;

    void OnValidate()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 angularVelocity = new Vector3(0, desiredLook.x, 0);
        _rigidbody.angularVelocity = angularVelocity * rotationSpeed;

        Vector3 forwardVelocity = _rigidbody.transform.forward * desiredMovement.y;
        Vector3 strafeVelocity = _rigidbody.transform.right * desiredMovement.x;
        _rigidbody.velocity = (forwardVelocity + strafeVelocity).normalized * (maxSpeed * Time.fixedDeltaTime);
    }

}
