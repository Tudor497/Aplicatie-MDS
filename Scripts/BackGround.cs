using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {


	public int textureSize = 32;
	// Use this for initialization
	void Start () {
        transform.position = PixelPerfectCamera.pos;
        //transform.position.z
		var newWidth = Mathf.Ceil (Screen.width / (textureSize * PixelPerfectCamera.scale));
		var newHeight = Mathf.Ceil (Screen.height / (textureSize * PixelPerfectCamera.scale));

		transform.localScale = new Vector3 (newWidth * textureSize,newHeight*textureSize,1);
		GetComponent<Renderer> ().material.mainTextureScale = new Vector3 (newWidth,newHeight,1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
