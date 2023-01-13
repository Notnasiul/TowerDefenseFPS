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

    private float _rotationY;

    void OnValidate()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rotationY += desiredLook.x * rotationSpeed * Time.fixedDeltaTime;
        _rigidbody.rotation = Quaternion.Euler(
            _rigidbody.rotation.eulerAngles.x,
            _rotationY,
            _rigidbody.rotation.eulerAngles.z);

        Vector3 forwardVelocity = _rigidbody.transform.forward * desiredMovement.y;
        Vector3 strafeVelocity = _rigidbody.transform.right * desiredMovement.x;
        _rigidbody.velocity = (forwardVelocity + strafeVelocity).normalized * (maxSpeed * Time.fixedDeltaTime);
    }

}
