using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public void OnClick_RegularMode()
    {
        GameStateManager.ChangeState(GameState.RegularMode);
    }

    public void OnClick_ChallengeMode()
    {
        GameStateManager.ChangeState(GameState.ChallengeMode);
    }

    public void OnClick_Back()
    {
        GameStateManager.ChangeState(GameState.Menu);
    }

}
