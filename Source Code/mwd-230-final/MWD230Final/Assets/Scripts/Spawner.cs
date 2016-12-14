using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] spawnPrefab;
	public GameObject me;
	public float spawnTime = 8f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
	}

	void SpawnEnemy () {
		int whichEnemy = Random.Range (0, 8);
		float xlocation = Random.Range ((me.transform.position.x - 2), (me.transform.position.x + 2));
		float ylocation = Random.Range ((me.transform.position.y - 2), (me.transform.position.y + 2));
		float zlocation = Random.Range ((me.transform.position.z - 2), (me.transform.position.z + 2));
		Instantiate (spawnPrefab[whichEnemy], new Vector3 (xlocation, ylocation, zlocation), Quaternion.identity);

		ConsoleData (whichEnemy, xlocation, ylocation, zlocation);
	}

	void ConsoleData(int whichOne, float x, float y, float z){
		if (whichOne == 0 || whichOne == 3 || whichOne == 6) {
			Debug.Log ("Aggressive Enemy Spawned at (" + x + ", " + y + ", " + z + ").\n");
		}
		if (whichOne == 1 || whichOne == 4 || whichOne == 7) {
			Debug.Log ("Passive Enemy Spawned at (" + x + ", " + y + ", " + z + ").\n");
		}
		if (whichOne == 2 || whichOne == 5 || whichOne == 8) {
			Debug.Log ("Sentry Spawned at (" + x + ", " + y + ", " + z + ").\n");
		}
	}
}
//Tushar Iyer