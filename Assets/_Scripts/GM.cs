using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GM : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    #region Singleton
    private static GM _instance;
    public static GM Instance => _instance;
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
    private void OnEnable()
    {
        Time.timeScale= 1.0f;
    }

    public static void GameOver()
    {
        Time.timeScale = 0f;
        GM.Instance.gameObject.SetActive(true);

    }
}