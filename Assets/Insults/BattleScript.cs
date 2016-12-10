using System.Collections;
using System.Collections.Generic;
using System;

using UnityEngine;
using UnityEngine.UI;

public class BattleScript : MonoBehaviour {

    public InsultReader insultReader;

    public Button playerButtonOne;
    public Button playerButtonTwo;
    public Button playerButtonThree;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public Text npcInsultText;

    public void npcInsult()
    {
        System.Random rnd = new System.Random();
        int insultIndex = rnd.Next(0, insultReader.insults.Count);
        npcInsultText.text = insultReader.insults[insultIndex];
        int randomInsultPower = rnd.Next(1, 4);
        int npcInsultPower = insultIndex * randomInsultPower;
    }

    public void playerInsults()
    {

    }


}
