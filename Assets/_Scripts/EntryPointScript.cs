using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointScript : MonoBehaviour
{
    private Collider collider;
    Rigidbody rb;
    private void Start()
    {
        collider = gameObject.GetComponent<Collider>();
        collider.isTrigger = true;
        EntryPointsManager.AddEntry(gameObject);
    }
    private void OnTriggerExit(Collider collision)
    {
        EntryPointsManager.RemoveEntry(gameObject);
        collider.isTrigger = false;
        rb = gameObject.AddComponent<Rigidbody>();
        rb.isKinematic = true;
    }
}
