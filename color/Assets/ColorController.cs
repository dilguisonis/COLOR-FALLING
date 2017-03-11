using UnityEngine;
using System.Collections;

public class ColorController : MonoBehaviour {
	public GameObject[] Line;

	// Use this for initialization
	void Start () {
		int i = 3;
		int random;
		int random2;
		foreach (GameObject lines in Line) {
			random2 = Random.Range (1, 4);
			i -= random2;
			if (i <=0 ) {
				
				lines.GetComponent<SpriteRenderer> ().color = GameObject.Find("Player").GetComponentInChildren<PlayerController> ().Color; 
				lines.transform.gameObject.tag = GameObject.Find("Player").GetComponent<PlayerController> ().ColorString;
				i = 100;
			
			} else {
				random = Random.Range (0, 3);
				switch (random) {
				case 0:
					lines.GetComponent<SpriteRenderer> ().color = GameObject.Find("Player").GetComponentInChildren<PlayerController> ().Color; // Blue Color WARNING!
					lines.tag = "Color Blue";
					break;
				case 1:
					lines.GetComponent<SpriteRenderer> ().color = new Color (255f,0f,0f); // Red Color
					lines.tag = "Color Red";
					break;
				case 2:
					lines.GetComponent<SpriteRenderer> ().color = new Color (240f,255f,0f); // Yellow Color
					lines.tag = "Color Yellow";
					break;
				case 3:
					lines.GetComponent<SpriteRenderer> ().color = new Color (71f,255f,0f); // Green Color
					lines.tag = "Color Green";
					break;
				}


			}

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
