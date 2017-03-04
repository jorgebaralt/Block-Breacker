using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static bool musicCounter = false;
	// Use this for initialization
	void Awake () {
	if(musicCounter == true){
		Debug.Log("duplicate music player self-destroy");
		Destroy(gameObject);

		
	}
	else
	{
			musicCounter = true;
			GameObject.DontDestroyOnLoad(gameObject);
	}
		
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
