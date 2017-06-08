using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {
    public float speed=0;
    public static BackgroundScroll curent;

    float pos = 0;

	// Use this for initialization
	void Start () {
        curent = this;
	}
	
	// Update is called once per frame
	void Go () {
        pos += speed;
        if (pos > 1.0f)
            pos -= 1.0f;
        Renderer r = GetComponent<Renderer>();
        r.material.mainTextureOffset = new Vector2(0, pos);
	}
}
