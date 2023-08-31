using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{

    public ScriptableObject coin;

    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {

            this.gameObject.SetActive(false);
            

        }

    }

}
