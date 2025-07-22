using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundInteractivity : MonoBehaviour
{
   public GameObject bgMusic;
    public GameObject icebergMusic;
   
    
         private void OnTriggerEnter(Collider other)
    {
        
        
        if (other.CompareTag("Player"))
        {
            bgMusic.SetActive(false);
            icebergMusic.SetActive(true);
        }
       
    }
    
}
