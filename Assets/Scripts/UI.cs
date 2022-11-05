using System;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private CubePool _cubePool;
    [SerializeField] private TextMeshProUGUI _speed;
    [SerializeField] private TextMeshProUGUI _distance;
    [SerializeField] private TextMeshProUGUI _time;
    [SerializeField] private TextMeshProUGUI _timer;
    [SerializeField] private TMP_InputField _speedInput;
    [SerializeField] private TMP_InputField _distanceInput;
    [SerializeField] private TMP_InputField _timeInput;


    private float _timeCounter;

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

    private void Update()
    {
        SpawnTimer();
    }

    private void SpawnTimer()
    {
        _timeCounter += Time.deltaTime;
        _timer.text = "Spawn process:" + Math.Round(_timeCounter / _cubePool.SpawnTimer * 100) + "%";
        if (_timeCounter >= _cubePool.SpawnTimer)
            _timeCounter = 0;
    }

    private void Innit()
    {
        SetSpeed(_cubePool.CubeSpeed.ToString());
        SetDistance(_cubePool.CubeDistance.ToString());
        SetSpawnTime(_cubePool.SpawnTimer.ToString());
        _speedInput.text = _cubePool.CubeSpeed.ToString();
        _distanceInput.text = _cubePool.CubeDistance.ToString();
        _timeInput.text = _cubePool.SpawnTimer.ToString();
    }

    private void Start()
    {
        Innit();
    }
}