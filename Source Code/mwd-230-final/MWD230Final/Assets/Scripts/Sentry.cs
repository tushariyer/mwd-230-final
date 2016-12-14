using UnityEngine;
using System.Collections;

public class Sentry : MonoBehaviour {
	public AudioSource inRange;
	//public AudioSource audi;
	public float fallback = 4;
	public float speed = 2f;
	public Transform target;
	public float chaseDistance = 15f;
	public GameObject self;

	// Use this for initialization
	void Start () {
		inRange = GetComponent<AudioSource> ();
		target = GameObject.FindWithTag ("Player").GetComponent<Transform> ();
		self = GetComponent<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
		inRange.Stop ();

		if (Mathf.Abs (target.position.x - transform.position.x) <= chaseDistance && Mathf.Abs (target.position.z - transform.position.z) <= chaseDistance) {
			inRange.Play ();
			transform.LookAt (target);
			transform.position += transform.forward * speed * Time.deltaTime;
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Sword") {
			transform.position -= transform.forward * fallback;
			Debug.Log("Sentry Killed.");
			//audi.Play ();
			Destroy (self);
		}
	}
}
//Tushar Iyer