using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC_NewLines : MonoBehaviour
{
   public GameObject DialougeBox;
   
    public TextMeshProUGUI dialougeComponent;
    public TextMeshProUGUI nextDialouge;

    public string[] lines;
    public float textSpeed;

    private int index;

    
    

    public void Interact(){
        DialougeBox.SetActive(true);
        dialougeComponent.text = string.Empty;
        nextDialouge.text = "Next [Left Click]";
        StartDialouge();
    }


  

    void StartDialouge()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    void Update()
    {

        
        if(Input.GetMouseButtonDown(0)){
            
                if(dialougeComponent.text == lines[index])
                {
                   
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    dialougeComponent.text = lines[index];
                }
            }
    }

    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            dialougeComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

        
        
    }

    void NextLine()
    {
        if (index < lines.Length - 1){
            index ++;
            dialougeComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else{
            DialougeBox.SetActive(false);
        }

        
    }
}
