using UnityEngine;

public class MenuManager : MonoBehaviour
{

    private void Start()
    {
        GameModeStateManager.ChangeState(GameModeState.Menu);
    }

    public void OnClick_RegularMode()
    {
        GameModeStateManager.ChangeState(GameModeState.RegularMode);
        LogicStateManager.ChangeLogicState(LogicState.WaitingToStart);
    }

    public void OnClick_ChallengeMode()
    {
        GameModeStateManager.ChangeState(GameModeState.ChallengeMode);
        LogicStateManager.ChangeLogicState(LogicState.WaitingToStart);
    }

    public void OnClick_Back()
    {
        GameModeStateManager.ChangeState(GameModeState.Menu);
        LogicStateManager.ChangeLogicState(LogicState.Default);
    }

}
