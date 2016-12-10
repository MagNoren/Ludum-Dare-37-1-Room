using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

using UnityEngine;

public class InsultReader : MonoBehaviour {

    public List<string> insults;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void getInsults(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            insults.Add(line);
        }
    }
}
