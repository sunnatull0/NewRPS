using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceManager : MonoBehaviour
{

    public static ReferenceManager Instance { get; private set; }


    public GameObject MenuUI;
    public GameObject RegularModeUI;
    public GameObject ChallengeModeUI;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
