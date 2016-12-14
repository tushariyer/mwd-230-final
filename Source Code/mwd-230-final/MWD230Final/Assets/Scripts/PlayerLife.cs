using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour {

	public Slider lifeSlider;
	public int maxLife;
	public int decayRate;
	public Text hudText;

	// Use this for initialization
	void Start () {
		lifeSlider.maxValue = maxLife;
		lifeSlider.value = maxLife;
	}

	// Update is called once per frame
	void Update () {
		lifeSlider.value -= Time.deltaTime * decayRate;

		if (lifeSlider.value <= 0) {
			Debug.Log ("You're dead, kid.");
			PlayerDied ();
		}
	}

	void PlayerDied(){
		hudText.text = ("Dead!");
		SceneManager.LoadScene ("Menu");
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Chest") {

			if (decayRate >= 2) {
				decayRate = (decayRate / 2);
				Debug.Log ("Decay Rate Halved!");
			}

			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "Fire") {
			lifeSlider.value -= 10;
			Debug.Log ("Burned!");
		}
	}
}
//Tushar Iyer