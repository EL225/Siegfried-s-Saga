using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public int health;
    
    
    
    
    public Animator animator;
    [SerializeField] GameObject enemy;
  
    

   
   
    public void TakeDamage(int damageAmount)
    {
        Debug.Log(health);
        
            health -= damageAmount;
            
        
        
        if(health <=0)
        {
            
            animator.SetTrigger("Death");
            Destroy(enemy,1f);
            
            

        }   
        else
        {
            
            animator.SetTrigger("Damage");

        }

        
        

        
    }

    public void StartDealDamage()
    {
        GetComponentInChildren<EnemyDamage>().StartDealDamage();
    }
    public void EndDealDamage()
    {
        GetComponentInChildren<EnemyDamage>().EndDealDamage();
    }

    
    
}
