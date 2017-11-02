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

        float mousPosInBlocks = (Input.mousePosition.x / Screen.width * 14) - 7f;

        paddlePosition.x = Mathf.Clamp(mousPosInBlocks, -6f, 6f);

        this.transform.position = paddlePosition;

        


    }
}
