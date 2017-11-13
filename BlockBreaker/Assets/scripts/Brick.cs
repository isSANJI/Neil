using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private LevelManager myLevelManager;

    public AudioClip crack;

    public static int breakableCount = 0;

    private bool isBreakable;

    void HandleHits()
    {
        timesHit++;
        if (timesHit >= maxHits)
        {
            //decrement the breakable bricks 
            //before destroying
            breakableCount--;
            myLevelManager.BrickDestroyed();
            Destroy(this.gameObject);
        }

    }


    void OnCollisionEnter2D(Collision2D collision)
    {

        AudioSource.PlayClipAtPoint(crack, transform.position);
        if (isBreakable)
        {
            HandleHits();
        }
        
        
    }

    void SimulateWin()
    {
        myLevelManager.LoadNextLevel();
    }


    public int maxHits;

    private int timesHit;

	// Use this for initialization
	void Start () {

        myLevelManager = GameObject.FindObjectOfType<LevelManager>();

        isBreakable = (this.tag == "Breakable");
        //keep track of breakable bricks
        if(isBreakable)
        {
            breakableCount++;
            print(breakableCount);
        }

        timesHit = 0;
        myLevelManager = GameObject.FindObjectOfType<LevelManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
