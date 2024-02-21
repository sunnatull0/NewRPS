using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSubscriber : MonoBehaviour
{

    private void Start()
    {
        // UI.
        EventManager.OnGameModeStateChangedToMenu += UIManager.SwitchToMenu;
        EventManager.OnGameModeStateChangedToRegularMode += UIManager.SwitchToRegularMode;
        EventManager.OnGameModeStateChangedToChallengeMode += UIManager.SwitchToChallengeMode;

        // RPS.
        EventManager.OnLogicStateChangedToWaitingToStart += GameLogic.Instance.ResetTimer;
        EventManager.OnLogicStateChangedToPlaying += RPSManager.Instance.CreateRPS;
    }

}
