using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public AudioClip crack;
	//private int maxHits;//initialize on unity
	public int timesHit;
	public Sprite[] hitSprites;
	public static int brickCount = 0;
	private bool isBreakable;
	private LevelManager levelManager;
	public GameObject smoke;
	
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		if(isBreakable){
			brickCount++;
		}
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		}
	
	// Update is called once per frame
	void Update () {
	
	
	}
	void OnCollisionEnter2D (Collision2D collision){

		AudioSource.PlayClipAtPoint(crack,transform.position);
		if(isBreakable){
			HandleHits();
		}

	}
	void HandleHits(){
		timesHit++;
		int maxHits = hitSprites.Length + 1;
		if(timesHit >= maxHits){
			brickCount--;
			levelManager.BrickDestroyed();
			Destroy(gameObject);
			//create smoke at brick position
			GameObject smokePuff = Instantiate(smoke,transform.position,Quaternion.identity) as GameObject;
			smokePuff.particleSystem.startColor = gameObject.GetComponent<SpriteRenderer>().color;
		}
		else {
			LoadSprites();
		}
	}
	
	//TODO Remove this method once we can actually win
	void SimulateWin(){
		levelManager.LoadNextLevel();
	}
	
	void LoadSprites(){
		int spriteIndex = timesHit-1;
		if(hitSprites[spriteIndex]){
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
}
