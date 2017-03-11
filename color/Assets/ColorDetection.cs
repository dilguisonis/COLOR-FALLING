using UnityEngine;
using System.Collections;

public class ColorDetection : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		GameObject.Find ("Player").GetComponent<PlayerController> ().GetColorPlayer ();
		Debug.Log (this.gameObject.tag + " es " + GameObject.Find("Player").GetComponent<PlayerController>().ColorString);
		if (this.gameObject.tag != GameObject.Find("Player").GetComponent<PlayerController>().ColorString) 
		{
			GameObject.Find("Player").GetComponent<PlayerController> ().isplaying = false;
		}
	}
}
