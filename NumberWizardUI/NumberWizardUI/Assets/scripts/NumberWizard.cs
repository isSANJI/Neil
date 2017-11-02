using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    //creates 3 number variables
    int min;
    int max;
    int guess;
    int maxGuessesAllowed = 10;

    public Text myText;

    public void GuessHigher()
    {
        min = guess;
        NextGuess();

    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();

    }

    void NextGuess()
    {
        //gives a Random number from 1 to 1000
        guess = Random.Range(min, max + 1);

        myText.text = guess.ToString();//converts int guess to string

        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 0) //Computer loses
        {
            SceneManager.LoadScene("Win"); //Player Wins
        }
    }

    void StartGame()
    {
        min = 1;
        max = 1001;
        //calling method NextGuess()
        NextGuess();
    }

    // Use this for initialization
    void Start () {

        StartGame();
        
        	
	}
	
	
}
