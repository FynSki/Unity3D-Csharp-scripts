using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAround : MonoBehaviour {

// ========================================
//
// Rotate around the Object Script
// version 1.0.0
// date - 2019-09-30
// update - 
// created by Adam Janiszewski
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
		
	}
	
// ========================================
//	UPDATE
// ========================================
	void Update () {
		RotationFunc();
	}

// ========================================
//	FUNCTIONS
// ========================================
	public void RotationFunc()
	{
		posX = rotationCenter.position.x + Mathf.Cos (angle) * rotationRadius;
		posY = rotationCenter.position.y + Mathf.Sin (angle) * rotationRadius;
		transform.position = new Vector2 (posX, posY);
		angle = angle + Time.deltaTime * (-1f * angularSpeed);

		if (angle >= 360f)
		{
			angle = 0f;
		}
	}

// END SCRIPT
}
