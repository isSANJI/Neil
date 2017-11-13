using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Paddle myPaddle;

    private bool hasStarted = false;

    private Vector3 paddleToBallVector;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted == true)
        {
            this.GetComponent<AudioSource>().Play();
            
        }
        
    }

    // Use this for initialization
    void Start () {

        //it is assigning the object of type Paddle it finds to myPaddle
        //rather than passing it from Unity myself
        myPaddle = GameObject.FindObjectOfType<Paddle>();

        paddleToBallVector = this.transform.position - myPaddle.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!hasStarted)
        {
            //lock the ball to the paddle
            this.transform.position = myPaddle.transform.position + paddleToBallVector;

            //if left mouse button is pressed --> 0
            if (Input.GetMouseButtonDown(0))
            {
                print("Left CLick");
                hasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }
	}
}
