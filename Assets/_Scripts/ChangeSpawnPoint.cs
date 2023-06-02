using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpawnPoint : MonoBehaviour
{
    [SerializeField] Transform BossSpawnPoint;
    private Rigidbody rb;
    private Collider collider;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();
        collider.isTrigger= true;
    }
    private void OnTriggerExit(Collider other)
    {
        SpawnManager.ChangeSpawnPoint(BossSpawnPoint);
        collider.isTrigger = false;
        rb = gameObject.AddComponent<Rigidbody>();
        rb.isKinematic = true;
    }
}
