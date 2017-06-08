using UnityEngine;
using UnityEngine.UI;
using System.Collections;

using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {
   
   
	public void ChangeScene()
	{
		SceneManager.LoadScene (1);
		Debug.Log ("HERE");
	}

	// Use this for initialization

}
