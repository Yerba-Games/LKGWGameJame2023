using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointScript : MonoBehaviour
{
    private Collider2D collider2D;
    Rigidbody2D rb;
    private void Start()
    {
        collider2D = gameObject.GetComponent<Collider2D>();
        collider2D.isTrigger = true;
        EntryPointsManager.AddEntry(gameObject);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        EntryPointsManager.RemoveEntry(gameObject);
        collider2D.isTrigger = false;
        rb = gameObject.AddComponent<Rigidbody2D>();
        rb.isKinematic = true;
    }
}
