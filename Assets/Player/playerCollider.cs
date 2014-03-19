using UnityEngine;
using System.Collections;

public class playerCollider : MonoBehaviour {

	public Rigidbody spawnPoint;
	public Rigidbody projectilePrefab;


	void OnCollisionEnter(Collision collision) 
	{
		if (collision.gameObject.tag == "Plane")
		{
			Debug.Log("Player hit plane. Dead!");
			StartGame.gameStarted = false;
			transform.position = spawnPoint.position;
		}

		if (collision.gameObject.tag == "Projectile")
		{
			Debug.Log("Player hit projectile. Dead!");
			StartGame.gameStarted = false;
			rigidbody.velocity = new Vector3(0, 0, 0);
			transform.position = spawnPoint.position;
		}
	}
}
