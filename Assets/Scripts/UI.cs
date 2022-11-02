using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private CubePool _cubePool;

    public void SetSpeed(string speed)
    {
        // int speed = Convert.ToInt32(value);
        // if ()
        // {
        //     int speed = Convert.ToInt32(value);
        // }
        _cubePool.CubeSpeed = Convert.ToInt32(speed);
    }
    
    public void SetDistance(string distance)
    {
        _cubePool.CubeDistance = Convert.ToInt32(distance);
    }
    
    public void SetSpawnTime(string time)
    {
        _cubePool.SpawnTimer = Convert.ToInt32(time);
    }
}
