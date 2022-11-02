using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _maxDistance;
    [SerializeField] private float _speed;

    private Coroutine _lifeCoroutine;

    public float MaxDistance
    {
        get => _maxDistance;
        set => _maxDistance = value;
    }

    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            new Vector3(transform.position.x, transform.position.y, _maxDistance), _speed * Time.deltaTime);
        if (transform.position.z >= _maxDistance)
        {
            Deactivate();
        }
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}