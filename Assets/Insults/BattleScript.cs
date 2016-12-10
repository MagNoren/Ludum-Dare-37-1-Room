using System.Collections;
using System.Collections.Generic;
using System;

using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class BattleScript : MonoBehaviour {

    public InsultReader insultReader;
    public GameManager gameManager;

    int wins;
    int losses;

    int npcNumber;

    public bool gamePause = false;

	// Use this for initialization
	void Start ()
    {
		
	}
	
    /// <summary>
    /// Checks if the player has won or lost
    /// </summary>
    void checkWins()
    {
        if (wins == 3)
        {
            gamePause = true;
            EditorUtility.DisplayDialog(
            "You win!", //Title
            "Well done!", //Message
            "Ok", //Option 0
            "" //Option 1
            );
        }
        if (losses == 3)
        {
            gamePause = true;
            EditorUtility.DisplayDialog(
            "You lost!", //Title
            "Well done!", //Message
            "Ok", //Option 0
            "" //Option 1
            );

        }
    }

	// Update is called once per frame
	void Update ()
    {
        checkWins();
	}

    //MARK: Mainloop
    void mainLoop()
    {
        if (gamePause == false)
        {
            npcInsult();
            playerInsults();
            gamePause = true;
        }

        if (totalPlayerPower > npcInsultPower)
        {
            wins += 1;
        }
        else
        {
            losses += 1;
        }
    }

    //MARK: NPC Insults
    public Text npcInsultText;
    int npcInsultPower;
    public void npcInsult()
    {
        System.Random rnd = new System.Random();
        int insultIndex = rnd.Next(0, insultReader.insults.Count);
        npcInsultText.text = insultReader.insults[insultIndex];
        int randomInsultPower = rnd.Next(1, 4);
        npcInsultPower = insultIndex * randomInsultPower;
    }

    //MARK: Player insults

    //The button texts
    public Text playerButtonOneText;
    public Text playerButtonTwoText;
    public Text playerButtonThreeText;
    //The player powers
    int insultOnePlayerPower;
    int insultTwoPlayerPower;
    int insultThreePlayerPower;

    int totalPlayerPower;

    void playerInsults()
    {
        if (!gamePause)
        {
            int insultIndex;
            System.Random rnd = new System.Random();

            insultIndex = rnd.Next(0, insultReader.insults.Count);
            playerButtonOneText.text = insultReader.insults[insultIndex];
            insultOnePlayerPower = insultReader.insultPowers[insultIndex];

            insultIndex = rnd.Next(0, insultReader.insults.Count);
            playerButtonOneText.text = insultReader.insults[insultIndex];
            insultTwoPlayerPower = insultReader.insultPowers[insultIndex];

            insultIndex = rnd.Next(0, insultReader.insults.Count);
            playerButtonOneText.text = insultReader.insults[insultIndex];
            insultThreePlayerPower = insultReader.insultPowers[insultIndex];
        }
        
        gamePause = true;
    }

    //MARK: Player buttons

    public void playerButtonOnePressed()
    {
        System.Random rnd = new System.Random();

        int delivery = rnd.Next(1, 4);

        int totalPlayerPower = delivery * insultOnePlayerPower;
    }

    public void playerButtonTwoPressed()
    {
        System.Random rnd = new System.Random();

        int delivery = rnd.Next(1, 4);

        int totalPlayerPower = delivery * insultTwoPlayerPower;
    }

    public void playerButtonThreePressed()
    {
        System.Random rnd = new System.Random();

        int delivery = rnd.Next(1, 4);

        totalPlayerPower = delivery * insultThreePlayerPower;
    }
}

