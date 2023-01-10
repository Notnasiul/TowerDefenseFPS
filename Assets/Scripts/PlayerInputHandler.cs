using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Movement))]
public class PlayerInputHandler : MonoBehaviour
{
    public float turnSensitivity;
    private Movement _movement;

    void OnValidate()
    {
        _movement = GetComponent<Movement>();
    }
    
    public void OnFire(InputValue value)
    {
        Debug.Log("PewPew");
    }

    public void OnMove(InputValue value)
    {
        Vector2 movement = value.Get<Vector2>();
        _movement.desiredMovement = movement;
    }

    public void OnLook(InputValue value)
    {
        Vector2 look = value.Get<Vector2>();
        _movement.desiredLook = look * turnSensitivity;
    }
}
