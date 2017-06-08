using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloc : MonoBehaviour {

    [SerializeField]
    BoxCollider2D playerColider;

    BoxCollider2D myColider;


	// Use this for initialization
	void Start () {
        myColider = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (playerColider.bounds.min.y < myColider.bounds.min.y && myColider.isTrigger == false)
            myColider.isTrigger = true;
        else if (playerColider.bounds.min.y > myColider.bounds.min.y && myColider.isTrigger == true)
            myColider.isTrigger = false;
    }
}
