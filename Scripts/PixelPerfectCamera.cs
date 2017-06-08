using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour {

	public static float pixelsToUnits = 1f;
	public static float scale=1f;
	public static float objRes = 1f;
    public static Vector3 pos;
	public Vector2 NativeResolution = new Vector2(240,160);
	// Use this for initialization
	void Awake (){
		var camera = GetComponent<Camera>();
        pos = camera.gameObject.transform.position;
        pos.z = 1;
            if (camera.orthographic) {
			scale = Screen.width / NativeResolution.y;
			pixelsToUnits *= scale;
			camera.orthographicSize = (Screen.height / 2.0f) / pixelsToUnits;
			objRes = camera.orthographicSize;

		}
	}
	

}
