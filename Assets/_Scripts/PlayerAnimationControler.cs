using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationControler : MonoBehaviour
{
    #region Singleton
    private static PlayerAnimationControler _instance;
    public static PlayerAnimationControler Instance => _instance;
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
    [SerializeField]Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator= GetComponent<Animator>();
    }
    public void DeathAnimation()
    {
        animator.Play("death");
    }
    public void AttackAnimation()
    {
        animator.Play("Attack");
    }
    public void DashAnimation()
    {
        animator.Play("Dash");
    }
    public void MovementAnimation() 
    {
        animator.SetTrigger("Move");
    }
    public void IdleAnimation()
    {
        animator.Play("idle");
    }
    
}
