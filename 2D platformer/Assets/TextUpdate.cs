using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class TextUpdate : MonoBehaviour
{

    public TextMeshProUGUI cointext;
    public SoOpenTrigger numberOfCoins;

    void Start()
    {
        
    }

    void Update()
    {


    }

    public void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {

            numberOfCoins.value += 1;
            Debug.Log("Vaule Update");

        }

    }

}
