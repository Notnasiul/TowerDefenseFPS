using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotation : MonoBehaviour
{
    public Transform headTransform;
    public Vector2 desiredLook;
    public float maxRotationAngle;
    public float rotationSpeed;

    private float _rotationX = 0;

    private void FixedUpdate()
    {
        _rotationX += desiredLook.y * rotationSpeed * Time.fixedDeltaTime;
        _rotationX = Mathf.Clamp(_rotationX, -maxRotationAngle, maxRotationAngle);

        headTransform.rotation = Quaternion.Euler(
            _rotationX,
            headTransform.eulerAngles.y,
            headTransform.eulerAngles.z);
    }
}
