using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using NaughtyAttributes;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    [SerializeField][Foldout("DashSettings")] float dashSpeed;
    [SerializeField][Foldout("DashSettings")] float dashCoolDownTime;
    bool canDash = true;
    private float dashStartingTime;
    //[SerializeField] float maxVelocit = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
       // if(rb.velocity.magnitude < maxVelocity )
       // {
            rb.velocity = new Vector2(moveInput.x, moveInput.y) * speed;
        //}


    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    void OnDash()
    {
        Debug.Log("1");
        if (canDash)
        {
            Debug.Log("2");
           transform.Translate(moveInput * dashSpeed);
            Debug.Log(moveInput * dashSpeed);
            canDash = false;
            dashStartingTime = dashCoolDownTime;
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