using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public Color Color;
	public string ColorString;
	public bool isplaying;

	Color BlueColor = new Color (0f,26f,223f);
	Color RedColor = new Color(255f,0f,0f);
	Color YellowColor = new Color(240f,255f,0f);
	Color GreenColor = new Color(71f,255f,0f);

	void Start(){
		GetColorPlayer ();
	}

	public void PlayerControllerConstructor (Color color)
	{
		Color = color;

		if((int)(this.gameObject.GetComponentInChildren<SpriteRenderer>().color.r * 1000) == (int)(BlueColor.r * 1000))
		{
			ColorString = "Color Blue";
		}
		if((int)(this.gameObject.GetComponentInChildren<SpriteRenderer>().color.r * 1000) == (int)(RedColor.r * 1000))
		{
			ColorString = "Color Red";
		}
		if((int)(this.gameObject.GetComponentInChildren<SpriteRenderer>().color.r * 1000) == (int)(YellowColor.r * 1000))
		{
			ColorString = "Color Yellow";
		}
		if((int)(this.gameObject.GetComponentInChildren<SpriteRenderer>().color.r * 1000) == (int)(GreenColor.r * 1000))
		{
			ColorString = "Color Green";
		}
	}
	public void GetColorPlayer()
	{
		PlayerControllerConstructor (GameObject.Find ("Player").GetComponentInChildren<SpriteRenderer> ().color);
	}
}
