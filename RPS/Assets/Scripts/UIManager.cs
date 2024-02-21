using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UIManager
{

    private static GameObject _menuUI;
    private static GameObject _regularModeUI;
    private static GameObject _challengeModeUI;

    private static bool _isInitialized = false;

    private static void Init()
    {
        _menuUI = ReferenceManager.Instance.MenuUI;
        _regularModeUI = ReferenceManager.Instance.RegularModeUI;
        _challengeModeUI = ReferenceManager.Instance.ChallengeModeUI;
        _isInitialized = true;
        Debug.Log("UI initialized!");
    }


    public static void SwitchToMenu()
    {
        if(!_isInitialized) Init();

        Disable(_regularModeUI);
        Disable(_challengeModeUI);
        Enable(_menuUI);
    }

    public static void SwitchToRegularMode()
    {
        if(!_isInitialized) Init();

        Disable(_menuUI);
        Enable(_regularModeUI);
    }

    public static void SwitchToChallengeMode()
    {
        if(!_isInitialized) Init();

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
