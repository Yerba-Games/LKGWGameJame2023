using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEntryPoints : MonoBehaviour
{
    #region Singleton
    private static BossEntryPoints _instance;
    public static BossEntryPoints Instance => _instance;
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
    [SerializeField] GameObject[] entryPoints;
    public void ActivateBossEntryPoints()
    {
        foreach (var entryPoint in entryPoints) { entryPoint.SetActive(true); }
    }
}
