using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    public float coolDownTime;
    public GameObject prefabToSpawn;

    private float _heat;

    void Start()
    {
        _heat = coolDownTime;
    }

    void Update()
    {
        _heat -= Time.deltaTime;
        if (_heat <= 0)
        {
            Spawn(prefabToSpawn);
            _heat = coolDownTime;
        }
    }

    void Spawn(GameObject prefabToSpawn)
    {
        Instantiate(
            prefabToSpawn, 
            transform.position,
            transform.rotation
        );
    }
}
