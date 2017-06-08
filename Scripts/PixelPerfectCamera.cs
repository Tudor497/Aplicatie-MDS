using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour {

	public static float pixelsToUnits;
	public static float scale;
	public static float objRes;
    public static Vector3 pos;
	public Vector2 NativeResolution = new Vector2(240,160);
	// Use this for initialization
	void Awake (){
      pixelsToUnits = 1f;
     scale = 1f;
     objRes = 1f;
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
