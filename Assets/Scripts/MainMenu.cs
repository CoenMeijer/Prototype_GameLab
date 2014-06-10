using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI()
	{
		if (GUI.Button(new Rect(Screen.width * 0.7f, Screen.height * 0.4f,Screen.width * 0.1f, Screen.height * 0.1f), "Play Game"))
		{
			Application.LoadLevel(1);
		}

		if (GUI.Button(new Rect(Screen.width * 0.7f, Screen.height * 0.6f,Screen.width * 0.1f, Screen.height * 0.1f), "Options"))
		{

		}

		if (GUI.Button(new Rect(Screen.width * 0.7f, Screen.height * 0.8f,Screen.width * 0.1f, Screen.height * 0.1f), "Exit Game"))
		{
			Application.Quit();
		}
	}
}
