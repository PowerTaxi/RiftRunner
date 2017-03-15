using UnityEngine;
using System.Collections;

public class ExitLever : MonoBehaviour {
	private Animation leverAmin;
	bool triggered;

	// Use this for initialization
	void Start () 
	{
		leverAmin = GetComponent<Animation> ();
	}
	
	void OnTriggerStay(Collider collider)
	{
		triggered = true;
		if ( SixenseInput.GetController(SixenseHands.LEFT).GetButton(SixenseButtons.TRIGGER)|| 
		    SixenseInput.GetController(SixenseHands.RIGHT).GetButton(SixenseButtons.TRIGGER))
		{
			leverAmin.Play ("down");
			Application.LoadLevel(0);
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
