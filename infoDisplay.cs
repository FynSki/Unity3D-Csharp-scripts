using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class infoDisplay : MonoBehaviour
{
/*
// ======================================== 
//
// info Setup Script
// version 1.0.1
// date - 2020-11-12
// update - 
// created by Adam Janiszewski
				change log

// ======================================== 
*/

// ========================================
//	VARIABLES
// ========================================  
    public int infoWasWatched;
    public GameObject infoUi;
// ========================================
//	START
// ======================================== 
    void Start()
    {
        loadPrefs();
    }

// ========================================
//	UPDATE
// ======================================== 
    void Update()
    {
        
    }

// ========================================
//	VARIABLES
// ======================================== 
   //Start Game or Info
    public void changeSceenFunc(string gameSceneToChange)
    { 
        if(infoWasWatched == 1)
        {
            SceneManager.LoadScene(gameSceneToChange);
            //PlayerPrefs.SetInt("infoPrefName" , 1);
        }
        else
        {
            infoUi.SetActive(true);
        }
        
    }

    public void assignePrefFunc(string gameSceneToChange)
    {
        PlayerPrefs.SetInt("infoPrefName" , 1);
        SceneManager.LoadScene(gameSceneToChange);
    }



    public void loadPrefs()
    {
        if(PlayerPrefs.HasKey("infoPrefName"))
            {
                infoWasWatched = PlayerPrefs.GetInt("infoPrefName");
            }
    }

// END SCRIPT
}
