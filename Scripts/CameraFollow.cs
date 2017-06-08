using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField]
    GameObject player;

    Vector3 poz;
    float coord_y;
   
    void Awake()
    {
        poz = new Vector3(transform.position.y, 1, transform.position.z);
    }

	// Use this for initialization
	void Start () {
        
        coord_y = player.transform.position.y;
        transform.position = poz + (Vector3.up * coord_y);
		
	}
	
	// Update is called once per frame
	void Update () {
        coord_y = Mathf.Max(coord_y, player.transform.position.y);

        transform.position = poz + (Vector3.up * coord_y);
		
	}
}
