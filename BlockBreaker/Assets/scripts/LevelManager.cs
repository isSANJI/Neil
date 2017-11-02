using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
    {
        print("Level Load requested for " + name);
        SceneManager.LoadScene(name); 
    }

    public void QuitGame()
    {
        print("BYE!");
        //UnityEditor.EditorApplication.isPlaying = false;
    }
    
  }
