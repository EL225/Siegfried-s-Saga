using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class Player_Interaction : MonoBehaviour
{
    
    bool allowEquip = false;
    bool newDialouge = false;
    bool dialouge = true;
    bool finishedNewDialouge = false;
    [SerializeField] GameObject sword;
    [SerializeField] GameObject shield;
     
     private void Update () {

        
        if(sword.activeSelf && shield.activeSelf && dialouge == false)
        {
             newDialouge = true;
        }
        
        if(dialouge == false && finishedNewDialouge == true)
        {
            dialouge = true;
            newDialouge = false;
            finishedNewDialouge = false;
        }
       

        
        if (Input.GetKeyDown(KeyCode.I)){
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray) {
                if(collider.TryGetComponent(out NPC_Interact npcInteract) && newDialouge == false){
                    npcInteract.Interact();
                    allowEquip = true;
                    dialouge = false;

                }
                
                 if(collider.TryGetComponent(out Object_Interact objectInteract) && allowEquip == true){
                    objectInteract.PickUpGear();
                    allowEquip = false;

                }
                
                if(collider.TryGetComponent(out NPC_NewLines npcNewLines) && newDialouge == true)
                {
                    npcNewLines.Interact();
                    finishedNewDialouge = true;
                    
                }
               
            }
                    
            
            
            
        }
        
        /*if (Input.GetKeyDown(KeyCode.I) && allowEquip == true){
            
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray) {
                  if(collider.TryGetComponent(out Object_Interact objectInteract)){
                    objectInteract.PickUpGear();
                }
            }

            allowEquip = false;
            newDialouge = true;
            
        }*/

        
     }

     public NPC_Interact GetInteractableObject(){
        List<NPC_Interact> npcInteractList = new List<NPC_Interact>();
       float interactRange = 2f;
       Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
       foreach (Collider collider in colliderArray){
            if(collider.TryGetComponent(out NPC_Interact npcInteract)){
                npcInteractList.Add(npcInteract);
                
            } 
       }

       NPC_Interact closestNPCInteractable = null;
            foreach (NPC_Interact npcInteract in npcInteractList){
                if (closestNPCInteractable == null) {
                    closestNPCInteractable = npcInteract;
                } else {
                    if (Vector3.Distance(transform.position, npcInteract.transform.position) < Vector3.Distance(transform.position, closestNPCInteractable.transform.position)){
                        closestNPCInteractable = npcInteract;
                    }
                }
            }
       return closestNPCInteractable;
     }

     

     public Object_Interact GetWeapon(){
        if(allowEquip == true)
        {
            
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray){
                if(collider.TryGetComponent(out Object_Interact objectInteract)){
                    return objectInteract;
                }
            }
            
        }
        return null;
     }
     
    
}
