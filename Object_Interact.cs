using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Interact : MonoBehaviour
{
    [SerializeField] private string interactText;
    public GameObject unequipedShield;
    public GameObject equipedShield;
     public GameObject unequipedWeapon;
    public GameObject equipedWeapon;
    
    
    public void PickUpGear(){
        unequipedShield.SetActive(false);
        equipedShield.SetActive(true);
        unequipedWeapon.SetActive(false);
        equipedWeapon.SetActive(true);
        
    }

   public string GetInteractText()
    {
        return interactText;
    }
   
}
