using System.Collections;
using System.Collections.Generic;
using System;

using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class BattleScript : MonoBehaviour {

    public InsultReader insultReader;
    public GameManager gameManager;
    public OverlevelManager overlevelManager;

    int wins;
    int losses;

    int npcNumber;

    public bool gamePause = false;

    public SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start ()
    {
        npcNumber = PlayerPrefs.GetInt("characterNumber");
        
	}

    public GameObject npcObject;

    public Sprite char1Sprite;
    public Sprite char2Sprite;
    public Sprite char3Sprite;
    public Sprite char4Sprite;
    public Sprite char5Sprite;
    public Sprite char6Sprite;
    public Sprite char7Sprite;
    public Sprite char8Sprite;

    void setSprites()
    {
        spriteRenderer = npcObject.GetComponent<SpriteRenderer>();
        if (npcNumber == 1)
        {
            spriteRenderer.sprite = char1Sprite;
        }
        if (npcNumber == 2)
        {
            spriteRenderer.sprite = char2Sprite;
        }
        if (npcNumber == 3)
        {
            spriteRenderer.sprite = char3Sprite;
        }
        if (npcNumber == 4)
        {
            spriteRenderer.sprite = char4Sprite;
        }
        if (npcNumber == 5)
        {
            spriteRenderer.sprite = char5Sprite;
        }
        if (npcNumber == 6)
        {
            spriteRenderer.sprite = char6Sprite;
        }
        if (npcNumber == 7)
        {
            spriteRenderer.sprite = char7Sprite;
        }
        if (npcNumber == 8)
        {
            spriteRenderer.sprite = char8Sprite;
        }

    }

    /// <summary>
    /// Checks if the player has won or lost
    /// </summary>
    void checkWins()
    {
        if (wins == 3)
        {
            gamePause = true;
            overlevelManager.wonAgainstChars.Add(npcNumber);
            overlevelManager.completedChars.Add(npcNumber);
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

