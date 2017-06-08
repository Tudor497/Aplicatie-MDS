using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedBackground : MonoBehaviour {

	public Vector2 Speed = new Vector2(0f,0.5f);
	private Vector2 Offset = Vector2.zero;
	private Material material;
	// Use this for initialization
	void Start () {
		material = GetComponent<Renderer> ().material;
		Offset = material.GetTextureOffset ("_MainTex");

		
	}
	
	// Update is called once per frame
	void Update () {
		Offset += Speed * Time.deltaTime;
		material.SetTextureOffset ("_MainTex", Offset);
	}
}
