using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour {

    public List<string> settings;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    /// <summary>
    /// Gets the settings from the file and makes a list of them
    /// Every other line is the actual setting. Settings start at 0 with the first name, then 1 with the first result
    /// </summary>
    public void getSettings()
    {
        var lines = File.ReadAllLines("settings.txt");
        foreach (var line in lines)
        {
            settings.Add(line);
        }
    }

    /// <summary>
    /// Saves the settings
    /// Is the button
    /// </summary>
    public void saveSettings()
    {
        File.WriteAllLines("settings.txt", settings.ToArray());
    }


    //The settings text that displays whether the swearing is allowed
    public Text swearingAllowedText;

    public GameManager gameManager;
    /// <summary>
    /// What controlls the settings canvas view. Doesn't do the buttons
    /// </summary>
    public void settingsView()
    {
        //Checks line 2 of the text file for the swearing setting
        if (settings[1] == "true")
        {
            //Sets to true in game
            swearingAllowedText.text = "Yes";
        }
        else
        {
            //Sets to false in game
            swearingAllowedText.text = "No";
        }
    }

    public void swearingPressed()
    {
        if (settings[1] == "true")
        {

        }
    }
        
    

}
