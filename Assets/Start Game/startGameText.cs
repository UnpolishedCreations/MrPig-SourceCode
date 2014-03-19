using UnityEngine;
using System.Collections;

public class startGameText : MonoBehaviour {
	
	 
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) == true)
		{
			Application.Quit();
		}
	}

	// Update is called once per frame
	void OnGUI() {

		GUIStyle myStyle = new GUIStyle();
		myStyle.fontSize = 24;

		GUIStyle quitStyle = new GUIStyle();
		quitStyle.fontSize = 18;

		if (!StartGame.gameStarted)
		{
			GUI.Label(new Rect(Screen.width / 3, Screen.height / 2, 100, 50), "Press Spacebar", myStyle);
			GUI.Label(new Rect(Screen.width / 3, Screen.height / 2 + 20, 100, 20), "to play game.", myStyle);

			GUI.Label(new Rect(Screen.width / 2, Screen.height /2, 100, 20), "ESC to quit the game.", quitStyle);
		}

	}
}