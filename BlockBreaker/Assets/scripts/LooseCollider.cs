using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {

    public LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D collider)
    {
        print("Trigger");
        levelManager.LoadLevel("Win");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");    
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
