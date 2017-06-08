using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilling : MonoBehaviour {

	// Use this for initialization
	public Renderer rend;
	void Start() {
		rend = GetComponent<Renderer>();
	}
	void Update() {
		float scaleX =  1;
		float scaleY =  1;
		rend.material.mainTextureScale = new Vector2(scaleX, scaleY);
	}
}
