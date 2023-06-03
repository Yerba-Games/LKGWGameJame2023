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
    [SerializeField] GameObject Wepon;
    Collider colliderl;
    void OnAttack(InputValue value)
    {
        isAttacking = true;
        AttackInput = new Vector3(value.Get<Vector2>().x, 0, value.Get<Vector2>().y);
    }
    private void Update()
    {
        if (isAttacking)
        {
        }
    }
}
