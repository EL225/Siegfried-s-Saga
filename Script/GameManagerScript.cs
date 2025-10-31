using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject victoryScreenUI;  
    public GameObject pauseMenuUI;   
    public GameObject gameCamera;
    
    public bool isPaused;
   
    // Start is called before the first frame update
    void Start()
    {
     
        Cursor.visible=false;
        Cursor.lockState = CursorLockMode.Locked;
     
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                pause();
            }
        }

        if(gameOverUI.activeInHierarchy || victoryScreenUI.activeInHierarchy || pauseMenuUI.activeInHierarchy)
        {
             Cursor.visible=true;
             Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }


    public void startGame()
    {
        
        SceneManager.LoadScene("Hammerfell");
        
    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);
        
    }

    public void victoryScreen()
    {
        victoryScreenUI.SetActive(true);
    }

    public void pause()
    {
        pauseMenuUI.SetActive(true);
        gameCamera.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        gameCamera.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;

    }

    public void mainMenu()
    {
       SceneManager.LoadScene("MainMenu");
       Time.timeScale = 1f;
    }
    
    
    public void quit()
    {
        
        Application.Quit();
    }
}
