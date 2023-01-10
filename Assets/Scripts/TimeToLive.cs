using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToLive : MonoBehaviour
{
    public float timeToLive;

    private float _spawnTime;

    void Awake()
    {
        _spawnTime = Time.time;
    }

    void Update()
    {
        float elapsedTime = Time.time - _spawnTime;
        if (elapsedTime > timeToLive) 
            Destroy(gameObject);
    }
}
