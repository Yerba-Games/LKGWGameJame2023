using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    Vector3 AttackInput;
    bool isAttacking = false;
    [SerializeField] Vector3 attackSize = new Vector3(1.5f, 1.5f, 1.5f);
    public int attackDamage;
    
    void OnAttack(InputValue value)
    {
        isAttacking = true;
        AttackInput = new Vector3(value.Get<Vector2>().x, 0, value.Get<Vector2>().y);
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.localPosition + AttackInput, AttackInput, out hit,2f))
            {
                Debug.Log("hit");
                // Check if the hit object has an Enemy script attached
                EnemyHealth enemy = hit.collider.GetComponent<EnemyHealth>();
                if (enemy != null)
                {
                    enemy.GetDamage(attackDamage);
                }
            }
        }
    }

}
