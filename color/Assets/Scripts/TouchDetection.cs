using UnityEngine;
using System.Collections;

public class TouchDetection : MonoBehaviour {
	
	public PlayerMovement PM;

	public float maxTime;
	public float minSwipeDist;

	public float leonardo; 

	public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}

	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
		
			if (touch.phase == TouchPhase.Moved) {
				if (touch.position.x >= -150 && touch.position.x <= 150 ) {
					if (player.gameObject.transform.position.x >= -150 || player.gameObject.transform.position.x <= 150) {
						Vector3 pos = Camera.main.ScreenToWorldPoint(touch.position);
						Debug.Log (pos);
						player.GetComponent<PlayerMovement> ().Move (pos.x);
					
					}
				}
			}

			/*
			if (touch.phase == TouchPhase.Began)
			{
				startTime = Time.time;
				startPos = touch.position;

				player.GetComponent<PlayerMovement> ().Move (touch.position.x);
			}
			else if (touch.phase == TouchPhase.Ended)
			{
				endTime = Time.time;
				endPos = touch.position;

				swipeDistance = (endPos - startPos).magnitude;
				swipeTime = endTime - startTime;

				if (swipeTime < maxTime && swipeDistance > minSwipeDist)
				{
					swipe();
				}
			}
			*/
		}
	}
		
}
