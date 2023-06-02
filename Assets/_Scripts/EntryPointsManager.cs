using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class EntryPointsManager : MonoBehaviour
{    
    #region Singleton
    private static EntryPointsManager _instance;
    public static EntryPointsManager Instance => _instance;
    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    #endregion
    public List<GameObject> EntryPoints;
    public void DoorsCheck()
    {
        if(EntryPoints== null) { GM.GameOver(); };
    }
    public static void AddEntry(GameObject entry)
    {
        EntryPointsManager.Instance.EntryPoints.Add(entry);
    }
    public static void RemoveEntry(GameObject entry) { EntryPointsManager.Instance.EntryPoints.Remove(entry);}

}
