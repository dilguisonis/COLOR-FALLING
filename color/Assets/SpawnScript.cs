using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public GameObject prefab;
	float time;
	// Use this for initialization
	void Start () {
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 1f) {
			Instantiate(prefab, new Vector2(0,200), Quaternion.identity);
			//HACER STACK
			time = 0;
		}

	}
}
