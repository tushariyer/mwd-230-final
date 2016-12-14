using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	public void StartPress(){
		SceneManager.LoadScene ("Primary");
	}

	public void QuitPress(){
		Application.Quit ();
	}

}
//Tushar Iyer