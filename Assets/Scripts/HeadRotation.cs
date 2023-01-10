using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotation : MonoBehaviour
{
    public Transform headTransform;
    public Vector2 desiredLook;
    public float maxRotationAngle;
    
    private void Update()
    {
        headTransform.Rotate(new Vector3(desiredLook.y, 0, 0));
        Vector3 clampedRotation = headTransform.rotation.eulerAngles;
        if (clampedRotation.x < 90)
        {
            clampedRotation.x = Mathf.Clamp(
                clampedRotation.x, 
                0, 
                maxRotationAngle);
        }
        else
        if (clampedRotation.x > 270)
        {
            clampedRotation.x = Mathf.Clamp(
                clampedRotation.x, 
                360-maxRotationAngle, 
                360);
        }
        headTransform.rotation = Quaternion.Euler(clampedRotation);
    }
}