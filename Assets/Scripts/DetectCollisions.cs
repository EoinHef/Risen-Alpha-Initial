using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    private void OnTriggerEnter(Collider other)
    {
        //Removing collisions with the terrain
        if (other.gameObject.transform.tag == "Ground")
        {
            //do Nothing
        }
        else
        {
            //Remove both game objects when they collide
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
