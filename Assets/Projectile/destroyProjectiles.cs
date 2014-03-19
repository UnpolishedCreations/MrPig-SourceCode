using UnityEngine;
using System.Collections;

public class destroyProjectiles : MonoBehaviour {

	public GameObject projectilePrefab;

	// Update is called once per frame
	void Update () 
	{
		if (projectilePrefab.transform.position.x <= -17)
		{
			Destroy(projectilePrefab);
			//playerScore.score = playerScore.score + 1;
			//Debug.Log("+1 score");
		}

		if(!StartGame.gameStarted)
		{
			Destroy(projectilePrefab);
		}
	}

	void OnCollisionEnter(Collision collision) 
	{
		if (collision.gameObject.tag == "Player")
		{
			playerScore.score = 0;
			Destroy(projectilePrefab);
			playerScore.score = 0;
		}
	}
}
