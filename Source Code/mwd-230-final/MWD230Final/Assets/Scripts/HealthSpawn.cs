using UnityEngine;
using System.Collections;

public class HealthSpawn : MonoBehaviour {

	public GameObject healthPrefab;
	public GameObject me;
	public float spawnTime = 15f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnHealth", spawnTime, spawnTime);
	}

	void SpawnHealth () {
		Instantiate (healthPrefab, new Vector3 ((me.transform.position.x + 2), me.transform.position.y, (me.transform.position.z - 1)), Quaternion.identity);
		Debug.Log ("HealthPack Spawned at (" + (me.transform.position.x + 2) + ", " + me.transform.position.y + ", " + (me.transform.position.z - 1) + ").\n");
	}
}
//Tushar Iyer