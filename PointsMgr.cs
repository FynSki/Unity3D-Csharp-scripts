using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsMgr : MonoBehaviour
{
/*
// ======================================== 
//
// Point Manager Script
// version 1.0.5
// date - 2020-06-04
// update - 2020-11-06
// created by Adam Janiszewski
				change log
    1. variables and ui system was added
    2. checking functions
    3. active ui and deactivation
    4. add reduce coin function
    5. Remodel Distance and add top distance
    6. restore coin text
// ======================================== 
*/

// ========================================
//	VARIABLES
// ========================================   
   
    // Coins
    public int coinCount;
    public int checkPoint;
    public string coinPrefName;

    // distance
    private Transform target;
    public string objToFollowtag;
    public float playerY;
    public float distPoint;
    public float hiDistance;
    public string bestDistPrefName;
    // Best score
    
    public int bestCP;
    public string bestCpPrefName;
    // Ball Count
    public int ballCount;
    // time
    public float timeCount;
    public int pointPerSec;

    // bools
    public bool gameOn;

    // Texts
    public Text timeText;
    public Text cointText;
    public Text cpText;
    public Text checkPointTxt;

    // GameObjects
    public GameObject endGameUI;
    public GameObject activeUi;

    // Sounds
    private SoundMgr soundM;
// ========================================
//	START
// ========================================  
    void Start()
    {
       ballCount = 1; 
       gameOn = true;

       CheckScoreFunc();

        soundM = FindObjectOfType<SoundMgr>();
        target = GameObject.FindGameObjectWithTag(objToFollowtag).GetComponent<Transform>();
    }

// ========================================
//	UNDATE
// ========================================
    void Update()
    {
        // Functions Trigger
        TimerFunc();
        ShowTextFunc();
        CheckBestScoresFunc();

        
        CheckDistanceFunc();
        
        

        // When End Game
        if(ballCount <= 0 || timeCount <= 0f)
        {
           //EndGameFunc(); 
        }
    }

    // ========================================
    //	FUNCTIONS
    // ========================================

    // Text 
    public void ShowTextFunc()
    {
        timeText.text = "Time: " + Mathf.Round(timeCount);
        cointText.text = "Coins: " + coinCount;
        cpText.text = "Distance: " + Mathf.Round(distPoint);
        //cpText.text = "Distance: " + (distPoint / 10f);
        //hiCpText.text = "High Score: " + bestCP;
        checkPointTxt.text = "Check Point: " + checkPoint;
    }

    // Timer
    public void TimerFunc()
    {
        timeCount -= pointPerSec * Time.deltaTime;
    }

    // End Game
    public void EndGameFunc()
    {
        soundM.EndSoundFunc();
        endGameUI.SetActive(true);
        activeUi.SetActive(false);
        pointPerSec = 0;
       

    }
    
    // Add Time
    public void AddTimeFunc(float timeToAdd)
    {
        timeCount = timeCount + timeToAdd;
        soundM.TimeSoundFunc();
    }
    // Add and reduce Points
    public void AddPoints(int coinsToAdd)
    {
        coinCount = coinCount + coinsToAdd;
        PlayerPrefs.SetInt(coinPrefName , coinCount);
        //checkPoint = checkPoint + cpToAdd;
        soundM.CoinSoundFunc();
    }
    // Add checkPoint
     public void Addcheckpoint(int cpToAdd)
    {
        //coinCount = coinCount + coinsToAdd;
        checkPoint = checkPoint + cpToAdd;
        soundM.LevelSoundFunc();
    }


    public void ReducePoints(int coinsToReduce)
    {
        coinCount = coinCount - coinsToReduce;
    }

    // Ball Count
    public void BallCountFunc(int ballCountToAdd , int ballCountToRemove)
    {
        ballCount = ballCount - ballCountToRemove;
        ballCount = ballCount + ballCountToAdd;
    }
    
    // Check Best Score
    public void CheckBestScoresFunc()
    {
        // best CP
        if(checkPoint > bestCP)
        {
            bestCP = checkPoint;
            PlayerPrefs.SetInt(bestCpPrefName , bestCP);
        }

        // Distance
        if(distPoint > hiDistance)
        {
            hiDistance = distPoint;
            PlayerPrefs.SetFloat(bestDistPrefName , hiDistance);
        }

        

    }

    // download PlayerPrefs
    public void CheckScoreFunc()
	{
    if(PlayerPrefs.HasKey(bestCpPrefName))
            {
                bestCP = PlayerPrefs.GetInt(bestCpPrefName);
            }
    
    if(PlayerPrefs.HasKey(bestDistPrefName))
            {
                hiDistance = PlayerPrefs.GetFloat(bestDistPrefName);
            }

     if(PlayerPrefs.HasKey(coinPrefName))
            {
                coinCount = PlayerPrefs.GetInt(coinPrefName);
            }

    }

    // check Distance
    public void CheckDistanceFunc()
    {   
        playerY = target.transform.localPosition.y;
        distPoint = playerY - (-1.61f);



    }

// END SCRIPT
}
