using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelect : MonoBehaviour {
	[SerializeField]
	string sceneName ="Game1";
	[SerializeField]
	string sceneName1="Main";
	public void ChangeScene()
	{   
		int choice = Random.Range(0, 2);
		if (choice == 0) {
			SceneManager.LoadScene (sceneName);
		} else {
			SceneManager.LoadScene (sceneName1);
		}
	}
}
