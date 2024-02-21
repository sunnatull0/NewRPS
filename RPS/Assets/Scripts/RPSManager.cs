using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPSManager : MonoBehaviour
{

    public static RPSManager Instance { get; private set; }

    [SerializeField] private List<GameObject> _rpsPrefabs;
    [SerializeField] private int _rpsAmount;

    [SerializeField] private GameObject _runTimeObjects;
    private List<GameObject> _rpsGameObjects;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }


    public void CreateRPS()
    {
        _rpsGameObjects = new List<GameObject>();
        GameObject obj;

        for (int i = 0; i < _rpsPrefabs.Count; i++)
        {
            for (int j = 0; j < _rpsAmount; j++)
            {
                obj = Instantiate(_rpsPrefabs[i], _runTimeObjects.transform);
                obj.SetActive(false);
                _rpsGameObjects.Add(obj);
            }
        }
        Debug.Log("RPSs created!");
    }

    public GameObject GetInactiveRPSGameObject()
    {
        for (int i = 0; i < _rpsAmount; i++)
        {
            if (!_rpsGameObjects[i].activeInHierarchy)
            {
                return _rpsGameObjects[i];
            }
        }
        return null;
    }

}
