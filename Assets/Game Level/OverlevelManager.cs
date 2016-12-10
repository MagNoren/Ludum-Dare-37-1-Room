using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlevelManager : MonoBehaviour {

    public GameObject Char1;
    public GameObject Char2;
    public GameObject Char3;
    public GameObject Char4;
    public GameObject Char5;
    public GameObject Char6;
    public GameObject Char7;
    public GameObject Char8;

    public List<int> wonAgainstChars;
    public List<int> lostAgainstChars;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void wonLostMarks()
    {
        if (wonAgainstChars.Contains(1))
        {

        }
    }


}
