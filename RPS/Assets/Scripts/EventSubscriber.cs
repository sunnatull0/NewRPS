using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSubscriber : MonoBehaviour
{
    
    private void Start()
    {
        // UI.
        EventManager.OnStateChangedToMenu += UIManager.SwitchToMenu;
        EventManager.OnStateChangedToRegularMode += UIManager.SwitchToRegularMode;
        EventManager.OnStateChangedToChallengeMode += UIManager.SwitchToChallengeMode;
    }

}
