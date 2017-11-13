using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string levelName)
    {
        print("Loading level " + levelName);
        //loads the Scene named levelName
        SceneManager.LoadScene(levelName);
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    //loads next Scene in Build Settings
    //make sure they are in the right order
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BrickDestroyed()
    {
        //if last brick is destroyed
        if (Brick.breakableCount <=0)
        {
            LoadNextLevel();
        }
    }
            

}
