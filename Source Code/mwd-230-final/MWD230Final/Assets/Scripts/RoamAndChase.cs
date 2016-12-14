using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]
public class RoamAndChase : MonoBehaviour
{
	public Transform target;
	public float chaseDistance = 15f;
	public float speed = 1.5f;
	public float directionDelay = 1f;
	public float maxHeadingChange = 30f;
	public AudioSource inRange;
	//public AudioSource audi;
	public GameObject self;
	public float fallback = 4;

	private float floor, ceil;

	CharacterController controller;
	float heading;
	Vector3 targetRotation;

	void Awake (){
		controller = GetComponent<CharacterController>();
		inRange = GetComponent<AudioSource> ();

		// Set random initial rotation
		heading = Random.Range(0, 360);
		transform.eulerAngles = new Vector3(0, heading, 0);

		target = GameObject.FindWithTag ("Player").GetComponent<Transform> ();
		self = GetComponent<GameObject> ();

		StartCoroutine(RandPath());
	}

	void Update (){
		//stop the music
		inRange.Stop ();

		//Roam around
		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionDelay);
		var forward = transform.TransformDirection(Vector3.forward);
		controller.SimpleMove(forward * speed);

		//within range
		if (Mathf.Abs (target.position.x - transform.position.x) <= chaseDistance && Mathf.Abs (target.position.z - transform.position.z) <= chaseDistance) {
			inRange.Play ();
			transform.LookAt (target);
			transform.position += transform.forward * speed * Time.deltaTime;
		}
	}

	IEnumerator RandPath (){
		while (true) {
			NewPath();
			yield return new WaitForSeconds(directionDelay);
		}
	}

	void NewPath (){
		floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
		ceil  = Mathf.Clamp(heading + maxHeadingChange, 0, 360);

		heading = Random.Range(floor, ceil);
		targetRotation = new Vector3(0, heading, 0);
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Sword") {
			transform.position -= transform.forward * fallback;
			Debug.Log("Aggressive Enemy Killed.");
			//audi.Play ();
			Destroy (self);
		}
	}
}
//Tushar Iyer