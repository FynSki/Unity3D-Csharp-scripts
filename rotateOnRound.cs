using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateOnRound : MonoBehaviour {

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
	public Transform rotationCenter;

	public float rotationRadius = 2f;
	public float angularSpeed = 2f;

	public float posX;
	public float posY;
	public float angle;
// ========================================
//	START
// ========================================
	void Start () {
		RotationOnRoundFunc();
	}
	
// ========================================
//	UPDATE
// ========================================
	void Update () {
		
	}

// ========================================
//	FUNCTIONS
// ========================================
	public void RotationOnRoundFunc()
	{
		posX = rotationCenter.position.x + Mathf.Cos (angle) * rotationRadius;
		posY = rotationCenter.position.y + Mathf.Sin (angle) * rotationRadius;
		transform.position = new Vector2 (posX, posY);
		angle = angle + (-1f * angularSpeed);

		if (angle >= 360f)
		{
			angle = 0f;
		}
	}

// END SCRIPT
}
