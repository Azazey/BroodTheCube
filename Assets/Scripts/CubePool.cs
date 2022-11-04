using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class CubePool : MonoBehaviour
{
    [SerializeField] private int _poolCount;
    [SerializeField] private bool _autoExpand;
    [SerializeField] private Cube _cubePrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _spawnTimer;
    [SerializeField] private UI _ui;
    
    private Pool<Cube> _pool;
    private float _cubeSpeed;
    private float _cubeDistance;

    public float CubeDistance
    {
        get => _cubeDistance;
        set => _cubeDistance = value;
    }

    public float CubeSpeed
    {
        get => _cubeSpeed;
        set => _cubeSpeed = value;
    }

    public float SpawnTimer
    {
        get => _spawnTimer;
        set => _spawnTimer = value;
    }

    private void Awake()
    {
        _pool = new Pool<Cube>(_cubePrefab, _poolCount, _autoExpand, transform);
        Invoke("CreateCube", _spawnTimer);
        StartCoroutine(_ui.CubeSpawnTime(_spawnTimer));
        _cubeSpeed = 2;
        _cubeDistance = 50;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            CreateCube();
        }
    }

    public void CreateCube()
    {
        var cube = _pool.GetFreeElement();
        cube.transform.position = _spawnPoint.position;
        cube.Speed = _cubeSpeed;
        cube.MaxDistance = _cubeDistance;
        Invoke("CreateCube", _spawnTimer);
        StartCoroutine(_ui.CubeSpawnTime(_spawnTimer));
    }
}
