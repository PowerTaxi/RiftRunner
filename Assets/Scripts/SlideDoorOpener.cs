using UnityEngine;
using System.Collections;

public class SlideDoorOpener : MonoBehaviour {
	
	GameObject door;
	bool triggered;
	private int anim_v;
	private Animation leverAmin;
	private Animation doorAnim;
	
	// Use this for initialization
	void Start () 
	{
		leverAmin = GetComponent<Animation> ();
		door = GameObject.Find ("SecondDoor");
		anim_v = 1;
		doorAnim = door.GetComponent<Animation> ();
	}


	void OnTriggerStay(Collider collider)
	{
		triggered = true;
		if ( SixenseInput.GetController(SixenseHands.LEFT).GetButton(SixenseButtons.TRIGGER)|| 
		    SixenseInput.GetController(SixenseHands.RIGHT).GetButton(SixenseButtons.TRIGGER)) 
		{
			if(anim_v == 1)
			{
				leverAmin.Play ("pull");
				doorAnim.Play ("Door2Open");
				leverAmin.Play("twist");
				anim_v = 2;
			}
			
//			if(anim_v == 2)
//			{
//				leverAmin.Play ("pull");
//				doorAnim.Play ("Door2Close");
//				leverAmin.Play("twist");
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
	
	
	
