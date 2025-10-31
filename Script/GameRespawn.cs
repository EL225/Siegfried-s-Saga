using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRespawn : MonoBehaviour
{
   
    public float threshold;


    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            
            transform.position = new Vector3(78.14f, 50.017f, 24.47f);

           
            
            
        }
    }
}
