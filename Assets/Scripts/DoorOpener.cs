using UnityEngine;
using System.Collections;

public class DoorOpener : MonoBehaviour {

	GameObject door;
	bool triggered;
	private int anim_v;
	private Animation leverAmin;
	private Animation doorAnim;

	// Use this for initialization
	void Start () 
	{
		anim_v = 1;
		leverAmin = GetComponent<Animation> ();
		door = GameObject.Find ("Hinge");
		doorAnim = door.GetComponent<Animation> ();
	}
	

	void OnTriggerStay(Collider collider)
	{
		triggered = true;
		if ( SixenseInput.GetController(SixenseHands.LEFT).GetButton(SixenseButtons.TRIGGER)|| 
		    SixenseInput.GetController(SixenseHands.RIGHT).GetButton(SixenseButtons.TRIGGER)) 
		{
				leverAmin.Play ("up");
				doorAnim.Play ("DoorOpen");
				leverAmin.Play("down");


//			if(anim_v == 2)
//			{
//				leverAmin.Play ("down");
//				doorAnim.Play ("DoorClose");
//				leverAmin.Play("up");
//				anim_v = 1;
//			}
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
