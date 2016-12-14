using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingWait : MonoBehaviour {
	IEnumerator Start () {
		yield return new WaitForSeconds (15f);
		SceneManager.LoadScene ("LevelOne");
	}
}
//Tushar Iyer