using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Facebook.Unity;
using UnityEngine.SceneManagement;

public class FBholder : MonoBehaviour {
	public GameObject DialogLoggedIn;
	public GameObject DialogLoggedOut;
	public GameObject DialogUsername;
	public GameObject DialogProfilePic;
	public  string username123;

	public Text playButton;

	void Awake()
	{
		FB.Init (SetInit, OnHideUnity);
	}

	void SetInit()
	{

		if (FB.IsLoggedIn) {
			Debug.Log ("FB is logged in");
			//SceneManager.LoadScene ("Menu");
		} else {
			Debug.Log ("FB is not logged in");
		}

		DealWithFBMenus (FB.IsLoggedIn);

	}

	void OnHideUnity(bool isGameShown)
	{

		if (!isGameShown) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}

	}

	public void FBlogin()
	{

		List<string> permissions = new List<string> ();
		permissions.Add ("public_profile");

		FB.LogInWithReadPermissions (permissions, AuthCallBack);
	}

	void AuthCallBack(IResult result)
	{

		if (result.Error != null) {
			Debug.Log (result.Error);
		} else {
			if (FB.IsLoggedIn) {
				Debug.Log ("FB is logged in");

			} else {
				Debug.Log ("FB is not logged in");
			}

			DealWithFBMenus (FB.IsLoggedIn);
		}

	}

	void DealWithFBMenus(bool isLoggedIn)
	{

		if (isLoggedIn) {
			DialogLoggedIn.SetActive (true);
			DialogLoggedOut.SetActive (false);

			FB.API ("/me?fields=first_name", HttpMethod.GET, DisplayUsername);
			FB.API ("/me/picture?type=square&amp;height=128&amp;width=128", HttpMethod.GET, DisplayProfilePic);

		} else {
			DialogLoggedIn.SetActive (false);
			DialogLoggedOut.SetActive (true);
		}

	}

	void DisplayUsername(IResult result)
	{

		Text UserName = DialogUsername.GetComponent<Text> ();

		if (result.Error == null) {
			GetName.USERNAME= result.ResultDictionary ["first_name"].ToString();
			UserName.text = "Hi there, " + result.ResultDictionary ["first_name"];
			playButton.text = "Play";


		} else {
			GetName.USERNAME = "Guest";
			Debug.Log (result.Error);
		}

	}

	void DisplayProfilePic(IGraphResult result)
	{

		if (result.Texture != null) {

			Image ProfilePic = DialogProfilePic.GetComponent<Image> ();

			ProfilePic.sprite = Sprite.Create (result.Texture, new Rect (0, 0, 50, 50), new Vector2 ());

		}

	}





}
