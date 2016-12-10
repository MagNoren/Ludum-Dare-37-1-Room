using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class LevelMover : MonoBehaviour {

    public OverlevelManager overlevelManager;

    public int characterNumber;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (overlevelManager.completedChars.Contains(characterNumber) == false)
        {
            PlayerPrefs.SetInt("characterNumber", characterNumber);
            EditorSceneManager.LoadScene("BattleScene");
        }
        
    }
}
