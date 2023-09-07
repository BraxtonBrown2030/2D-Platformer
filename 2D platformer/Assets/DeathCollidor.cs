using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollidor : MonoBehaviour
{

    public Canvas deathcavas;
    
    void Start()
    {
        
        deathcavas.enabled = false;

    }



    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {

            deathcavas.enabled = true; 
            Destroy(other.gameObject);           

        }

    }
}
