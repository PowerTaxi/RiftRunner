using UnityEngine;
using System.Collections;

public class BacktoMenu : MonoBehaviour {
	SixenseInput.Controller hydraLeftController = SixenseInput.GetController (SixenseHands.LEFT);

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(SixenseInput.GetController(SixenseHands.LEFT).GetButton(SixenseButtons.THREE))
			Application.LoadLevel(0);
		if(SixenseInput.GetController(SixenseHands.LEFT).GetButton(SixenseButtons.ONE))
			Application.LoadLevel(4);
		if(Input.GetKeyDown("q"))
		   Application.Quit();
	
	}
}
