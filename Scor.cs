using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scor : MonoBehaviour {
    public GUIText scorText;
    public static int scor=0;
	// Use this for initialization
	void Start () {
        scorText.text = "SCOR" + scor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
