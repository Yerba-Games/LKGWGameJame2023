using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using NaughtyAttributes;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    private Vector3 moveInput;
    [SerializeField][Foldout("DashSettings")] float dashSpeed;
    [SerializeField][Foldout("DashSettings")] float dashCoolDownTime;
    bool canDash = true;
    private float dashStartingTime;
    
    //[SerializeField] float maxVelocit = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    void FixedUpdate()
    {
       // if(rb.velocity.magnitude < maxVelocity )
       // {
            rb.velocity = moveInput * speed;
        //}
        if (moveInput * speed == Vector3.zero)
        {
            PlayerAnimationControler.Instance.IdleAnimation();
        }
        else
        {
            PlayerAnimationControler.Instance.MovementAnimation();
        }


    }
    void OnMove(InputValue value)
    {
        moveInput =new Vector3 (-value.Get<Vector2>().x,0, -value.Get<Vector2>().y);

    }
    void OnDash()
    {
        Debug.Log("1");
        if (canDash)
        {
            Sound.PlayDash();
            Debug.Log("2");
           transform.Translate(moveInput * dashSpeed);
            Debug.Log(moveInput * dashSpeed);
            canDash = false;
            dashStartingTime = dashCoolDownTime;
            PlayerAnimationControler.Instance.DashAnimation();
        }
    }
        void Update() 
    {
        if (!canDash && dashStartingTime > 0)
        {
            dashStartingTime -= Time.deltaTime;

        }
        else
        {
            canDash = true;
        }
    }

}