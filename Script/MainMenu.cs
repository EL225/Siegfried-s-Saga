using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject creditMenu;
    public GameObject titleScreen;

    public void startGame()
    {
        SceneManager.LoadScene("Hammerfell");
    }
   public void CreditMenu()
    {
        creditMenu.SetActive(true);
        titleScreen.SetActive(false);

    }

    public void TitleScreen()
    {
        creditMenu.SetActive(false);
        titleScreen.SetActive(true);
    }
    public void quit()
    {
        
        Application.Quit();
    }
}
