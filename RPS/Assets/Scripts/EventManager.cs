using System;

public static class EventManager
{

    public static Action 
                        OnGameModeStateChangedToMenu,
                        OnGameModeStateChangedToRegularMode,
                        OnLogicStateChangedToDefault,
                        OnLogicStateChangedToWaitingToStart,
                        OnLogicStateChangedToPlaying,
                        OnLogicStateChangedToWon,
                        OnLogicStateChangedToLost,
                        OnGameModeStateChangedToChallengeMode;
                        
}
