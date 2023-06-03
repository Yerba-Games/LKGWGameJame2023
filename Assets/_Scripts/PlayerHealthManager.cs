using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    #region Singleton
    private static PlayerHealthManager _instance;
    public static PlayerHealthManager Instance => _instance;
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
    [SerializeField]int health;
    int baseHealth;
    private void Start()
    {
        baseHealth = health;
    }
    public static void Damage(int damage)
    {
        PlayerHealthManager.Instance.health-=damage;
        if (PlayerHealthManager.Instance.health <= 0)
        {
            Death();
        }

    }
    public static void Death()
    {
        if(EntryPointsManager.Instance.EntryPoints.Count > 0) 
        {
            PlayerAnimationControler.Instance.DeathAnimation();
            Sound.PlaySpawn();
            SpawnManager.Spawn();
            PlayerHealthManager.Instance.health = PlayerHealthManager.Instance.baseHealth;
        }
        else
        {
            Debug.Log("GAMEOVER");
        }
    }
}
