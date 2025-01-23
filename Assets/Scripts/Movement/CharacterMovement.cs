using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MovementState
{
    IDLE,
    WALK,
    RUN
}

public class CharacterMovement : MonoBehaviour
{

    private Rigidbody2D pmRb;
    private Vector2 moveVector;
    public float movementSpeed;
    public MovementState movementState;
    bool groundCheck;
    
    private void Awake()
    {
        pmRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
    
        GetState();
    }
    private void FixedUpdate()
    {
        GetAxis();
        SetVelocity();
    }


    public void GetState()
    {
        if(pmRb.velocity.magnitude == 0 )
        {
            movementState = MovementState.IDLE;
        }
        else if(pmRb.velocity.magnitude == movementSpeed)
        {
            movementState = MovementState.WALK;
        }
    }

    public void GetAxis()
    {

        moveVector = new Vector2(Input.GetAxis("Horizontal") , Input.GetAxis("Vertical"));
        if (moveVector.magnitude > 1)
        {
            moveVector = moveVector.normalized;
        }

    }

    public void SetVelocity()
    {
        pmRb.velocity = moveVector * movementSpeed;
        
    }
    
}
