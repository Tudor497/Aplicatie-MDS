using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsResize : MonoBehaviour {

	// Use this for initialization
	public int textureSize = 1;
	void Start () {

		var camera = GetComponent<Camera>();
		var newWidth = PixelPerfectCamera.objRes / 34f;
		var newHeight = PixelPerfectCamera.objRes / 34f;

		transform.localScale = new Vector3 (newWidth,newHeight,1);



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
