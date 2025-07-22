using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRuneStone : MonoBehaviour
{

    public GameObject Boss;
    public GameObject RuneStone;
    public GameObject frozenBeach;
    public GameObject unfrozenBeach;
    public GameObject beachBackgroundSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Boss == null)
        {
            RuneStone.SetActive(true);
            frozenBeach.SetActive(false);
            unfrozenBeach.SetActive(true);
            beachBackgroundSound.SetActive(true);
        }
    }
}
