using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
 	private LevelManager levelManager;
	void OnTriggerEnter2D(Collider2D trigger){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		levelManager.LoadLevel("win");
	}

	void OnCollisionEnter2D(Collision2D collision){
		print ("collision");
	}


	// Use this for initialization
	void Start () {
	
	
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
