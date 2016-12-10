using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System;

using UnityEngine;

public class InsultReader : MonoBehaviour {

    public List<string> insults;
    public List<int> insultPowers;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public GameManager gameManager;
    public void getInsults()
    {
        if (gameManager.swearsAllowed == true)
        {
            var lines = File.ReadAllLines("Assets\\Insults\\vulgarInsults.txt");
            foreach (var line in lines)
            {
                insults.Add(line);
            }
            foreach (var insult in insults)
            {
                int index = insults.IndexOf(insult);
                if (index % 2 == 0)
                {
                    //Is even: Leave it
                }
                else
                {
                    //Is odd: Remove, add to insultPowers
                    insultPowers.Add(Int32.Parse(insult));
                    insults.Remove(insult);
                }
            }
        }
        else
        {
            //Double backslash because \ is escape so to use \ we escape the escape
            var lines = File.ReadAllLines("Assets\\Insults\\cleanInsults.txt");
            foreach (var line in lines)
            {
                insults.Add(line);
            }
        }
        
    }
}
