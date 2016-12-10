using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMover : MonoBehaviour {

    public OverlevelManager overlevelManager;

    public int characterNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerPrefs.SetInt("characterNumber", characterNumber);
    }
}
