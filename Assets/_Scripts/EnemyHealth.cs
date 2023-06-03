using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]int health;
    public void GetDamage(int damage)
    {
        health-=(int)damage;
        if (health == 0)
        {
            Sound.PlayEnemyDeath();
            Destroy(gameObject);
        }
    }
}
