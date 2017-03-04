﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	public bool autoPlay = false;
	private Ball ball;
	
	void Start(){
		ball = GameObject.FindObjectOfType<Ball>();
	}

	// Update is called once per frame
	void Update () {
	if(!autoPlay){
		MoveWithMouse();
		}
	else{
		AutoPlay();
	}
		
	}
	
	void MoveWithMouse(){
		float min = 0.5f;
		float max = 15.5f;
		
		Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp(mousePosInBlocks,min,max);
		transform.position = paddlePos;
	}
	
	void AutoPlay(){
		float min = 0.5f;
		float max = 15.5f;
		Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x,min,max);
		transform.position = paddlePos;
	}
	
}