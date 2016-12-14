using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour {
	private Animator anim;
	private AudioSource audi;

	void Start () {
		anim = GetComponent<Animator> ();
		audi = GetComponent<AudioSource> ();
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.F)){
			anim.SetTrigger ("attack");
			audi.Play ();
		}
	}
}
//Tushar Iyer