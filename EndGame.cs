using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndGame : MonoBehaviour
{   
    public GameManagerScript gameManager;
    public AudioSource runeStoneSfx;

    private void Start()
    {
        runeStoneSfx.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameManager.victoryScreen();
        }
    }

}
