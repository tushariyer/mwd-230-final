using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HitStuff : MonoBehaviour {

	public Slider lifeSlider;
	public int enemyDamage = 5;
	public Text taskText;
	public Object Win;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "HealthPack") {
			Debug.Log ("Health Replenished.\n");
			lifeSlider.value = 100;

			Destroy (other.gameObject);
		} 

		if (other.gameObject.tag == "WinBall" || other == Win) {
			lifeSlider.value = 100;
			Debug.Log ("WinBall Collected.\n");

			taskText.text = ("Level Complete!");
			SceneManager.LoadScene ("Finale");
			Debug.Log ("Game Complete!\n");
		}

		if (other.gameObject.tag == "DeathPill") {
			Debug.Log ("Taking Enemy Damage!\n");
			lifeSlider.value -= enemyDamage;
		}
	}
}
//Tushar Iyer