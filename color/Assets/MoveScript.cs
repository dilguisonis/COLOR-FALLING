using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	float time;
	// Use this for initialization
	void Start () {
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = Vector2.MoveTowards (transform.position, new Vector2(0f,-200f), Time.deltaTime * 50f);
	}
}
