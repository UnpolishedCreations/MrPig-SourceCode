using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	static public bool gameStarted = false;

	// Use this for initialization
	void Start () {
		gameStarted = false;
		playerScore.addScore = false;
		rigidbody.constraints = RigidbodyConstraints.FreezePositionX |
								RigidbodyConstraints.FreezePositionY |
								RigidbodyConstraints.FreezePositionZ |
								RigidbodyConstraints.FreezeRotationX |
								RigidbodyConstraints.FreezeRotationY |
								RigidbodyConstraints.FreezeRotationZ ;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Jump") && !gameStarted)
		{
			playerScore.score = 0;
			playerScore.currLevel = 1;
			StartCoroutine("initScore");
			gameStarted = true;
		}

		// Set's gravity on player once game starts
		if (gameStarted)
		{
			rigidbody.useGravity = true;
			rigidbody.constraints = ~RigidbodyConstraints.FreezePositionY;

		}
		else
		{
			StopCoroutine("initScore");
			rigidbody.useGravity = false;
			rigidbody.constraints = RigidbodyConstraints.FreezePositionX |
									RigidbodyConstraints.FreezePositionY |
									RigidbodyConstraints.FreezePositionZ |
									RigidbodyConstraints.FreezeRotationX |
									RigidbodyConstraints.FreezeRotationY |
									RigidbodyConstraints.FreezeRotationZ ;

			playerScore.increase1 = true;
			playerScore.increase2 = true;
			playerScore.increase3 = true;
			playerScore.increase4 = true;
			playerScore.increase5 = true;
			playerScore.increase6 = true;

			obstacleCreator.waitTimeForFire = obstacleCreator.startWaitTimeForFire;
			obstacleCreator.projectileSpeed = obstacleCreator.startProjectileSpeed; 
		}
	}

	IEnumerator initScore()
	{
		while(true) 
		{
			playerScore.score = playerScore.score + 1;
			yield return new WaitForSeconds(1);
		}
	}
	
}
