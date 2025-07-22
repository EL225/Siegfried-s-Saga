using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnteringHamerfell : MonoBehaviour
{
   public GameObject bgMusic;
    public GameObject icebergMusic;
   
    
         private void OnTriggerEnter(Collider other)
    {
        
        
        if (other.CompareTag("Player") && bgMusic.activeSelf == false)
        {
            bgMusic.SetActive(true);
            icebergMusic.SetActive(false);
        }
       
    }

}
