using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 paddlePosition = new Vector3(0.5f, this.transform.position.y, 0f);

        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 8;
        print(mousePosInBlocks);

        paddlePosition.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 7.5f);

        this.transform.position = paddlePosition;

        

        

        
		
	}
}
