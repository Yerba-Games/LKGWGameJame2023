using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Collider2D collider2D;
    private Rigidbody2D rb;
    private void Start()
    {
        collider2D=gameObject.GetComponent<Collider2D>();
        collider2D.isTrigger=true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        collider2D.isTrigger=false;
        rb=gameObject.AddComponent<Rigidbody2D>();
        rb.isKinematic = true;
    }
}
