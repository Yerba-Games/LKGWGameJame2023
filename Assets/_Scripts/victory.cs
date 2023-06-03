using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory : MonoBehaviour
{
    [SerializeField] GameObject Object;
    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0f;
        Object.SetActive(true);
    }
    private void OnEnable()
    {
        Time.timeScale = 1f;
    }
}
