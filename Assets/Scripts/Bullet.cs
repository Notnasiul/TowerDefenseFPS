using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody _rigidbody;
    
    public void Start()
    {
        _rigidbody.velocity = transform.forward * speed;
    }
}
