using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

// ========================================
//
// Box Script
// version 1.0.0
// date - 
// update - 
// created by 
//
// ========================================

// ========================================
//	VARIABLES
// ========================================
	public float zDir;
	public int roundToSet;
	public int roundToMove;

	private roundManager roundMgr;
// ========================================
//	START
// ========================================
	void Start () {
		roundMgr = FindObjectOfType<roundManager>();
	}
	
// ========================================
//	UPDATE
// ========================================
	void Update () {
		Rotate();
	}

// ========================================
//	FUNCTIONS
// ========================================
	public void Rotate()
	{
		if(roundMgr.roundNr == roundToMove)
		{
			transform.Rotate( new Vector3(0 , 0 , zDir));
			roundMgr.changeRound(roundToSet);
		}
		
	}


// END SCRIPT
}
