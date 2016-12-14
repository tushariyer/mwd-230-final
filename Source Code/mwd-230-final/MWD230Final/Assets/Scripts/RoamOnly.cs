using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class RoamOnly : MonoBehaviour
{
	public Transform target;
	public float speed = 2f;
	public float chaseDistance = 15f;
	public float directionChangeInterval = 1f;
	public float maxHeadingChange = 30f;
	public AudioSource inRange;
	//public AudioSource audi;
	public GameObject self;
	public float fallback = 4;

	CharacterController controller;
	float heading;
	Vector3 targetRotation;

	void Awake ()
	{
		controller = GetComponent<CharacterController>();
		inRange = GetComponent<AudioSource> ();

		// Set random initial rotation
		heading = Random.Range(0, 360);
		transform.eulerAngles = new Vector3(0, heading, 0);

		target = GameObject.FindWithTag ("Player").GetComponent<Transform> ();
		self = GetComponent<GameObject> ();

		StartCoroutine(NewHeading());
	}

	void Update ()
	{
		//Check the distance
		//float distance = Vector3.Distance (transform.position, target.position);
		inRange.Stop ();

		//Roam around
		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
		var forward = transform.TransformDirection(Vector3.forward);
		controller.SimpleMove(forward * speed);

		//within range
		if (Mathf.Abs (target.position.x - transform.position.x) <= chaseDistance && Mathf.Abs (target.position.z - transform.position.z) <= chaseDistance) {
			inRange.Play ();
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Sword") {
			transform.position -= transform.forward * fallback;
			Debug.Log("Passive Enemy Killed.");
			//audi.Play ();
			Destroy (self);
		}
	}

	IEnumerator NewHeading ()
	{
		while (true) {
			NewHeadingRoutine();
			yield return new WaitForSeconds(directionChangeInterval);
		}
	}

	void NewHeadingRoutine ()
	{
		var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
		var ceil  = Mathf.Clamp(heading + maxHeadingChange, 0, 360);
		heading = Random.Range(floor, ceil);
		targetRotation = new Vector3(0, heading, 0);
	}
}
//Tushar Iyer