using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public void ExitButton() {
		Application.Quit();
		Debug.Log("Game closed");
	}

	public void ToMenu() {
		SceneManager.LoadScene("Aliens_Fashion_Menu");
	}
}