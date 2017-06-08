using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour {
    public float upForce = 200f;
    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;

	void Start () {
        rb2d = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator>();
	}
	
	void Update () {
		if(isDead==false)
        {
            if(Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
            }
        }
	}
    private void OnCollisionEnter2D()
    {
        isDead = true;
        anim.SetTrigger("Die");
		if (PlayerIsAlive.getflag () == true) {
			SceneManager.LoadScene ("Game1");
			PlayerIsAlive.flag = false;
		} else {
			SceneManager.LoadScene ("GameLost");
			PlayerIsAlive.flag = true;
		}

        GameControll.instance.birdDied ();
        rb2d.velocity = Vector2.zero;
    }
}
