using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour {
	[SerializeField]
	Text textField;
	public static string USERNAME="Guest";

	// Use this for initialization
	void Start () {
		
		textField.text = USERNAME;
	
	}
	

}
