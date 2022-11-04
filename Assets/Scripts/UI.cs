using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private CubePool _cubePool;
    [SerializeField] private TextMeshProUGUI _speed;
    [SerializeField] private TextMeshProUGUI _distance;
    [SerializeField] private TextMeshProUGUI _time;
    [SerializeField] private TextMeshProUGUI _timer;

    public void SetSpeed(string speed)
    {
        if (Checkers.isDigits(speed))
        {
            _cubePool.CubeSpeed = Convert.ToInt32(speed);
            _speed.text = $"Speed:{speed}";
        }
    }
    
    public void SetDistance(string distance)
    {
        if (Checkers.isDigits(distance))
        {
            _cubePool.CubeDistance = Convert.ToInt32(distance);
            _distance.text = $"Distance:{distance}";
        }
    }
    
    public void SetSpawnTime(string time)
    {
        if (Checkers.isDigits(time))
        {
            _cubePool.SpawnTimer = Convert.ToInt32(time);
            _time.text = $"Time:{time}";
        }
    }
    
    public IEnumerator CubeSpawnTime(float timeToSpawn)
    {
        for (float i = 0; i < timeToSpawn; i += Time.deltaTime)
        {
            _timer.text = "Spawn process:" + Math.Round(i / timeToSpawn * 100) + "%";
            yield return null;
        }
    }

    private void Start()
    {
        SetSpeed(_cubePool.CubeSpeed.ToString());
        SetDistance(_cubePool.CubeDistance.ToString());
        SetSpawnTime(_cubePool.SpawnTimer.ToString());
    }
}
