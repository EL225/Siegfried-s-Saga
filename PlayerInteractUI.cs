using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerInteractUI : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private GameObject containerWeapon;
    [SerializeField] private Player_Interaction playerInteraction;
    [SerializeField] private TextMeshProUGUI interactTextMeshProUGUI;
   

    [SerializeField] private TextMeshProUGUI weaponInteractTextMeshProUGUI;



    private void Update(){
        if(playerInteraction.GetInteractableObject() != null){
            ShowI(playerInteraction.GetInteractableObject() );
           
        }
        else{
            HideI();
        }

        if(playerInteraction.GetWeapon() != null){
            
            ShowE(playerInteraction.GetWeapon());
        }
        else{
            HideE();
        }
    } 
   
   private void ShowI(NPC_Interact npcInteractable)
   {
        containerGameObject.SetActive(true);
        interactTextMeshProUGUI.text = npcInteractable.GetInteractText();
        
   }

    private void HideI(){
        containerGameObject.SetActive(false);
    }
    private void ShowE(Object_Interact objInteract){
        containerWeapon.SetActive(true);
        weaponInteractTextMeshProUGUI.text = objInteract.GetInteractText();
    }

    private void HideE(){
        containerWeapon.SetActive(false);
    }
}
