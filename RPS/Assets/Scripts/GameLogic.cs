using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GameLogic : MonoBehaviour
{

    public static GameLogic Instance { get; private set; }


    [SerializeField] private float _waitingToStartTime = 1f;
    private float _currentTime = 0f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }


    private void Update()
    {

        if (LogicStateManager.state != LogicState.WaitingToStart)
            return;


        if (_currentTime < _waitingToStartTime)
        {
            _currentTime += Time.deltaTime;
            Debug.Log(Math.Round(_currentTime));
        }
        else
        {
            ResetTimer();
            LogicStateManager.ChangeLogicState(LogicState.Playing);
        }

    }

    public void ResetTimer()
    {
        _currentTime = 0f;
        Debug.Log("Timer reseted!");
    }
}
