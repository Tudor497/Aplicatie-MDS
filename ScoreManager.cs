using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {
    [SerializeField]
    GameObject player;
    [SerializeField]
    Text scorTxt;


    float scor;

    float coord_init, coord_curenta, coord_maxima;


	// Use this for initialization
	void Start () {
        coord_maxima = coord_init = player.transform.position.y;
        scor = 0;
        
	}
	
	// Update is called once per frame
	void Update () {

        coord_curenta = player.transform.position.y;
        if (coord_curenta > coord_maxima)
        {
            coord_maxima = coord_curenta;
            scor =  coord_maxima - coord_init;
            scor /= 10;
            scorTxt.text = "Scor: " + Mathf.Round(scor);
            
        }
        
	}
}
