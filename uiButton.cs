using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiButton : MonoBehaviour
{
 /* ========================================

    UI Buttons Script
    version 1.0.1
    date - 2020-04-22
    update - 2020-09-18
    created by Adam Janiszewski

    ===CHANGE LOG:===
    1. dodanie zmiany UI

    =================

// ========================================
*/ 
// ========================================
//	VARIABLES
// ========================================
   
// ========================================
//	FUNCTIONS
// ========================================
    public void changeSceen(string gameSceneToChange)
    { 
        SceneManager.LoadScene(gameSceneToChange);
    }

    public void ExitGame()
	{
		Application.Quit();
	}

    public void UiToActiveFunc(GameObject toActive)
    {
        toActive.SetActive(true);
    }

    public void UiToDeactiveFunc(GameObject toDeactive)
    {
        toDeactive.SetActive(false);
    }


}
