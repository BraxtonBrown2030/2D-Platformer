using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    [SerializeField] private Camera thisCamera;
    public Transform player;

    void Start()
    {
        
        

    }

    void Update()
    {


        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);


    }
}
