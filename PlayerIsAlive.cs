using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerIsAlive : MonoBehaviour {
	public static bool flag=true;
    
	public static bool getflag(){
		return flag;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnBecameInvisible()
	{   if (flag == true) {
			SceneManager.LoadScene ("Main");
			flag = false;
		} else {
			SceneManager.LoadScene ("GameLost");
		flag = true;
		}
        
    }
}
