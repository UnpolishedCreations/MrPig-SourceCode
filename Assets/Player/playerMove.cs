using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	public int jumpHeight = 4;

	void Update() {

		if (Input.GetButtonDown("Jump") && StartGame.gameStarted)
		{
			rigidbody.velocity = new Vector3(0, jumpHeight, 0);
		}

	}
}
