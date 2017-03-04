using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	//we want to load a new level.
	//when click start, load game scene. 
	public void LoadLevel(string name){
	Debug.Log("Level load requested for: " +name);
	Brick.brickCount = 0;
	Application.LoadLevel(name);
	
	}
	public void QuidRequest(){
	Debug.Log("Request for quit.");
	Application.Quit();
	}
	public void LoadNextLevel(){
	Brick.brickCount = 0;
	Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void BrickDestroyed(){
		if(Brick.brickCount<=0){
			LoadNextLevel();
		}
	}
	
}
