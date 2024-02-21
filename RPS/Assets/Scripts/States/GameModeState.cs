public enum GameModeState
{
    Menu,
    RegularMode,
    ChallengeMode,
}

public static class GameModeStateManager
{
    
    public static GameModeState state = GameModeState.Menu;

    public static void ChangeState(GameModeState desiredState)
    {
        switch(desiredState)
        {
            case GameModeState.Menu:
                EventManager.OnGameModeStateChangedToMenu?.Invoke();
                break;

            case GameModeState.RegularMode:
                EventManager.OnGameModeStateChangedToRegularMode?.Invoke();
                break;

            case GameModeState.ChallengeMode:
                EventManager.OnGameModeStateChangedToChallengeMode?.Invoke();
                break;
        }

        state = desiredState;
    }

}