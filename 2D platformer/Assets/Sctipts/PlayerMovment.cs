using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    
    [Header("Player Componts")]
    private Rigidbody2D ts;

    [Header("jumpvalue")]
    [SerializeField] private int jumpvalue;

    void Start()
    {
        
        ts = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    void Jump()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {

            ts.position = new Vector2(transform.position.x, jumpvalue);

        }

    }
}
