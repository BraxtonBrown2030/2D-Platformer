using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    
    [Header("Player movement")]
    [SerializeField] private float speed;
    [SerializeField] private float jumphight;
    private Rigidbody2D rB2D;

    [Header("ground check")]
    private bool isgournded;
    public Transform groundcheck;
    [SerializeField] private float groundCheckRadius;
    public LayerMask whatisground;
    private float moveVolocity;

    void Start()
    {
        
        isgournded = true;
        rB2D = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
       
        isgournded = Physics2D.OverlapCircle(groundcheck.position, groundCheckRadius, whatisground);

        moveVolocity = 0f;

        if(Input.GetKey(KeyCode.D))
        {

            moveVolocity = speed;

        }

        if(Input.GetKey(KeyCode.A))
        {

            moveVolocity = -speed;

        }

        rB2D.velocity = new Vector2(moveVolocity, rB2D.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && isgournded)
        {

            Jump();

        }

    }

    void Jump()
    {

        rB2D.velocity = new Vector2(rB2D.velocity.x, jumphight);

    }
}
