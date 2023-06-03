using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Collider collider;
    private Rigidbody rb;
    private void Start()
    {
        collider=gameObject.GetComponent<Collider>();
        //collider.isTrigger=true;
    }
    private void OnTriggerExit(Collider collision)
    {
        collider.isTrigger=false;
        rb=gameObject.AddComponent<Rigidbody>();
        rb.isKinematic = true;
    }
}
