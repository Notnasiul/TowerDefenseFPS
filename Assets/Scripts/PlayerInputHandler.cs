using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(HeadRotation))]
public class PlayerInputHandler : MonoBehaviour
{
    public float turnSensitivity;
    public Weapon weapon;
    private Movement _movement;
    private HeadRotation _headRotation;

    void OnValidate()
    {
        _movement = GetComponent<Movement>();
        _headRotation = GetComponent<HeadRotation>();
    }

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    public void OnFire(InputValue value)
    {
        if (weapon != null)
        {
            weapon.Fire();
        }
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
        _headRotation.desiredLook = look * turnSensitivity;
    }
}
