using UnityEngine;
using System.Collections;

public class HelpScript : MonoBehaviour {
	bool triggered;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			triggered = true;
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
			GUI.Label (new Rect (10, 100, 350, 20), "Look Right.");
		}
	}


}
