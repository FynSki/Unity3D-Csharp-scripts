using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMgr : MonoBehaviour
{
/*
// ======================================== 
//
// Sound Manager Script
// version 1.0.3
// date - 2020-09-11
// update - 2020-11-06
// created by Adam Janiszewski
				change log
   1. dodanie wyłączneia i włączenia dźwięków
   2. zaczytywanie zapisanego stanu dźwięku
// ======================================== 
*/

// ========================================
//	VARIABLES
// ========================================  
    public AudioSource clickSound;
	public AudioSource endGameSound;
    public AudioSource coinSound;
    public AudioSource timeSound;
    public AudioSource levelSound;

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
        //checkSoundPref();
    }

// ========================================
//	FUNCTIONS
// ========================================
    public void CoinSoundFunc()
    {
        if(soundActive)
        {
            coinSound.Play();
        }
        
    }

     public void EndSoundFunc()
    {
         if(soundActive)
        {
            endGameSound.Play();
        }
        
    }

     public void ClickSoundFunc()
    {
         if(soundActive)
        {
            clickSound.Play();
        }
        
    }

     public void TimeSoundFunc()
    {
         if(soundActive)
        {
            timeSound.Play();
        }
        
    }

    public void LevelSoundFunc()
        {
            if(soundActive)
            {
                levelSound.Play();
            }
            
        }

    
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
