using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
   public HP_Bar hitPoints;
 
   public GameManagerScript gameManager;
   public GameObject shield;
    public float health, maxHealth;
    private bool isDead;

    
   
    public Animator animator;

    void Start()
    {
        //health = maxHealth;
    }

        public void TakeDamage(int amount)
    {
        if(shield.activeSelf == false)
        {
            
            health -= amount;
        }
        else
        {
            animator.SetTrigger("HitBlocked");
        }
        
        hitPoints.GetComponent<HP_Bar>().DrawHearts();

        

        if(health <= 0 && !isDead)
        {
            
            animator.SetBool("IsDead", true);
            isDead = true;
            gameManager.gameOver();
            
            
        }
        else if(health >=0 && shield.activeSelf == false)
        {
            animator.SetTrigger("IsHit");
        }
    }
  
 private void OnTriggerEnter(Collider other)
    {
        
        if(other.transform.tag == "Coin")
        {
             health += 1; 
            if(health <= maxHealth)
            {
               
                hitPoints.GetComponent<HP_Bar>().DrawHearts();
                Debug.Log(health);
                 Debug.Log("Healing");
             }
            
        }
    }

   

}
