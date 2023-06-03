using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    #region Singleton
    private static SpawnManager _instance;
    public static SpawnManager Instance => _instance;
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
    [SerializeField] GameObject StartSpawn;
    private Transform spawnTransform;
    [SerializeField] GameObject Player;
    private void Start()
    {
        spawnTransform = StartSpawn.transform;
    }
    public static void Spawn()
    {
        Sound.PlaySpawn();
        SpawnManager.Instance.Player.transform.position = SpawnManager.Instance.spawnTransform.position;
    }
    public static void ChangeSpawnPoint(Transform spawnPoint)
    {
        SpawnManager.Instance.spawnTransform = spawnPoint;
        EntryPointsManager.Instance.EntryPoints.Clear();
        BossEntryPoints.Instance.ActivateBossEntryPoints();

    }
}
