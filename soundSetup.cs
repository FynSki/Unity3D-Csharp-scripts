using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundSetup : MonoBehaviour
{
/*
// ======================================== 
//
// Sound Setup Script
// version 1.0.1
// date - 2020-11-09
// update - 
// created by Adam Janiszewski
				change log

// ======================================== 
*/

// ========================================
//	VARIABLES
// ========================================  
    public bool soundActive;
    public int soundPref;

    public GameObject activButton;
    public GameObject deactiveButton;
// ========================================
//	START
// ========================================  
    void Start()
    {
         checkSoundPref();
    }

// ========================================
//	UPDATE
// ========================================  
    void Update()
    {
        
    }


// ========================================
//	FUNCTIONS
// ========================================  
// włączenie i wyłączenie dźwieków
    public void SoundActiveFunc()
    {
        activButton.SetActive(false);
        deactiveButton.SetActive(true);
        soundActive = true;
        soundPref = 1;
        PlayerPrefs.SetInt("soundPrefName" , 1);
    }

    public void SoundDeactiveFunc()
    {
        activButton.SetActive(true);
        deactiveButton.SetActive(false);
        soundActive = false;
        soundPref = 0;
        PlayerPrefs.SetInt("soundPrefName" , 0);
    }

    public void checkSoundPref()
    {
        if(PlayerPrefs.HasKey("soundPrefName"))
            {
                soundPref = PlayerPrefs.GetInt("soundPrefName");
            }
        
        if(soundPref == 0)
        {
            activButton.SetActive(true);
            
            soundActive = false;
        }
        else
        {
            deactiveButton.SetActive(true);
            soundActive = true;
        }
    }



// END SCRIPT
}
