using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
   public int damageAmount;
   public bool canDealDamage;
   public bool hasDealtDamage;
    private void OnTriggerExit(Collider other)
    {
       
        if(other.CompareTag("Player") && canDealDamage == true && hasDealtDamage == false)
        {
           
            other.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
            
            
            canDealDamage = false;
            hasDealtDamage = true;
        }

    }

    public void StartDealDamage()
    {
        canDealDamage = true;
        hasDealtDamage = false;
    }
    public void EndDealDamage()
    {
        canDealDamage = true;
    }




}
