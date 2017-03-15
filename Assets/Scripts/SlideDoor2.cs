using UnityEngine;
using System.Collections;

public class SlideDoor2 : MonoBehaviour {
	GameObject door;
	bool triggered;
	private int anim_v;
	private Animation leverAmin;
	private Animation doorAnim;
	
	// Use this for initialization
	void Start () 
	{
		leverAmin = GetComponent<Animation> ();
		door = GameObject.Find ("ThirdDoor");
		anim_v = 1;
		doorAnim = door.GetComponent<Animation> ();
	}
	
	
	void OnTriggerStay(Collider collider)
	{
		triggered = true;
		if ( SixenseInput.GetController(SixenseHands.LEFT).GetButton(SixenseButtons.TRIGGER)|| 
		    SixenseInput.GetController(SixenseHands.RIGHT).GetButton(SixenseButtons.TRIGGER)) 
		{
		
				leverAmin.Play ("down");
				doorAnim.Play ("Door3Open");
		}
	}
	void OnTriggerExit()
	{
		triggered = false;
	}
	
	void onGUI()
	{
		if (triggered = true) {
			GUI.contentColor = Color.red;  
			GUI.Label (new Rect (10, 100, 350, 20), "Grab lever with your hand.");
		}
	}
}


