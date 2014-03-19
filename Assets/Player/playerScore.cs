using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class playerScore : MonoBehaviour {

	public AudioClip levelUpSFX;

	static public int score = 0;
	static public int highScore = 0;
	static public int currLevel = 1;

	static public bool increase1 = true;
	static public bool increase2 = true;
	static public bool increase3 = true;
	static public bool increase4 = true;
	static public bool increase5 = true;
	static public bool increase6 = true;

	static public bool addScore = false;
	
	public GameObject player;
	public Rigidbody levelUp;
	private Rigidbody levelUpCreate;

	// Use this for initialization
	void Start () {
		score = 0;
		currLevel = 1;
		audio.clip = levelUpSFX;
	}

	void Update()
	{
		if (score > highScore)
		{
			highScore = score;
		}

		if (score >= 10 && score <= 20 && StartGame.gameStarted)
		{
			if (increase1) 
			{
				obstacleCreator.projectileSpeed = obstacleCreator.projectileSpeed + 1;
				levelUpCreate = Instantiate(levelUp, player.transform.position, transform.rotation) as Rigidbody;
				Destroy(levelUpCreate);
				audio.Play();
				currLevel = currLevel + 1;
				increase1 = false;
			}

		}
		else if (score >= 21 && score <= 31 && StartGame.gameStarted)
		{
			if (increase2)
			{
				obstacleCreator.waitTimeForFire = obstacleCreator.waitTimeForFire - 0.5F;
				levelUpCreate = Instantiate(levelUp, player.transform.position, transform.rotation) as Rigidbody;
				Destroy(levelUpCreate);
				audio.Play();
				currLevel = currLevel + 1;
				increase2 = false;
			}
		}
		else if (score >= 32 && score <= 50 && StartGame.gameStarted)
		{
			if (increase3)
			{
				obstacleCreator.projectileSpeed = obstacleCreator.projectileSpeed + 1;
				levelUpCreate = Instantiate(levelUp, player.transform.position, transform.rotation) as Rigidbody;
				Destroy(levelUpCreate);
				audio.Play();
				currLevel = currLevel + 1;
				increase3 = false;
			}
		}
		else if (score >= 51 && score <= 70 && StartGame.gameStarted)
		{
			if (increase4)
			{
				obstacleCreator.waitTimeForFire = obstacleCreator.waitTimeForFire - 0.5F;
				levelUpCreate = Instantiate(levelUp, player.transform.position, transform.rotation) as Rigidbody;
				Destroy(levelUpCreate);
				audio.Play();
				currLevel = currLevel + 1;
				increase4 = false;
			}
		}
		else if (score >= 71 && score <= 99 && StartGame.gameStarted)
		{
			if (increase5)
			{
				obstacleCreator.projectileSpeed = obstacleCreator.projectileSpeed + 1;
				levelUpCreate = Instantiate(levelUp, player.transform.position, transform.rotation) as Rigidbody;
				Destroy(levelUpCreate);
				audio.Play();
				currLevel = currLevel + 1;
				increase5 = false;
			}
		}
		else if (score >= 100 && score <= 120 && StartGame.gameStarted)
		{
			if (increase6)
			{
				obstacleCreator.waitTimeForFire = obstacleCreator.waitTimeForFire - 0.5F;
				levelUpCreate = Instantiate(levelUp, player.transform.position, transform.rotation) as Rigidbody;
				Destroy(levelUpCreate);
				audio.Play();
				currLevel = currLevel + 1;
				increase6 = false;
			}
		}
	}
	
	void OnGUI() {
		
		GUIStyle myStyle = new GUIStyle();
		myStyle.fontSize = 24;

		GUI.Label(new Rect(Screen.width / 10 - 10, Screen.height - 30, 100, 50), "Score: " + score, myStyle);
		GUI.Label(new Rect(Screen.width / 3, Screen.height - 30, 100, 50), "High Score: " + highScore, myStyle);

		if(currLevel < 6)
		{
			GUI.Label(new Rect(Screen.width / 5, Screen.height - 30, 100, 50), "Level: " + currLevel, myStyle);
		}
		else
		{
			GUI.Label(new Rect(Screen.width / 5, Screen.height - 30, 100, 50), "Level: Survive", myStyle);
		}
		
	}
}
