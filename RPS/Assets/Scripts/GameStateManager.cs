using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStateManager
{
    
    private static GameState state = GameState.Menu;

    public static void ChangeState(GameState desiredState)
    {
        switch(desiredState)
        {
            case GameState.Menu:
                EventManager.OnStateChangedToMenu?.Invoke();
                break;

            case GameState.RegularMode:
                EventManager.OnStateChangedToRegularMode?.Invoke();
                break;

            case GameState.ChallengeMode:
                EventManager.OnStateChangedToChallengeMode?.Invoke();
                break;
        }

        state = desiredState;
    }

}
