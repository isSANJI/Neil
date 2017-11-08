using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public LevelManager myLevelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        if (timesHit >= maxHits)
        {
            Destroy(this.gameObject);
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

        timesHit = 0;
        myLevelManager = GameObject.FindObjectOfType<LevelManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
