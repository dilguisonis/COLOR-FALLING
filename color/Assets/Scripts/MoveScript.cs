using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	
    public float speed = 50f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = Vector2.MoveTowards (transform.position, new Vector2(0f,-250f), Time.deltaTime * speed);
	}
}
