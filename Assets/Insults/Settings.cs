using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;

public class Settings : MonoBehaviour {

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
    /// </summary>
    public void saveSettings()
    {
        File.WriteAllLines("settings.txt", settings.ToArray());
    }

    /// <summary>
    /// What controlls the settings canvas view. Doesn't do the buttons
    /// </summary>
    public void settingsView()
    {

    }

}
