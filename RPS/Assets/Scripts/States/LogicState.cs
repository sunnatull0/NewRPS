public enum LogicState
{
    Default,
    WaitingToStart,
    Playing,
    Won,
    Lost
}

public static class LogicStateManager
{

    public static LogicState state = LogicState.Default;

    public static void ChangeLogicState(LogicState desiredState)
    {
        switch(desiredState)
        {
            case LogicState.Default:
                EventManager.OnLogicStateChangedToDefault?.Invoke();
                break;

            case LogicState.WaitingToStart:
                EventManager.OnLogicStateChangedToWaitingToStart?.Invoke();
                break;

            case LogicState.Playing:
                EventManager.OnLogicStateChangedToPlaying?.Invoke();
                break;

            case LogicState.Won:
                EventManager.OnLogicStateChangedToWon?.Invoke();
                break;

            case LogicState.Lost:
                EventManager.OnLogicStateChangedToLost?.Invoke();
                break;
        }

        state = desiredState;
    }

}