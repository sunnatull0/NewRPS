using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UIManager
{
    
    private static GameObject _menuUI = ReferenceManager.Instance.MenuUI;
    private static GameObject _regularModeUI = ReferenceManager.Instance.RegularModeUI;
    private static GameObject _challengeModeUI = ReferenceManager.Instance.ChallengeModeUI;

    
    public static void SwitchToMenu()
    {
        Disable(_regularModeUI);
        Disable(_challengeModeUI);
        Enable(_menuUI);
    }
    
    public static void SwitchToRegularMode()
    {
        Disable(_menuUI);
        Enable(_regularModeUI);
    }

    public static void SwitchToChallengeMode()
    {
        Disable(_menuUI);
        Enable(_challengeModeUI);
    }



    private static void Enable(GameObject obj)
    {
        obj.SetActive(true);
    }

    private static void Disable(GameObject obj)
    {
        obj.SetActive(false);
    }

}
