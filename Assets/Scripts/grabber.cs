using UnityEngine;
using System.Collections;

public class grabber : MonoBehaviour {
	bool usable;
	bool grabbed;
	GameObject grabber1 = null;
	SixenseInput.Controller hydraLeftController = SixenseInput.GetController(SixenseHands.LEFT);
	
	
	// Use this for initialization
	// Use this for initialization
	void Start () {
		usable = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(usable && (SixenseInput.GetController(SixenseHands.LEFT).GetButton(SixenseButtons.TRIGGER) || SixenseInput.GetController(SixenseHands.RIGHT).GetButton(SixenseButtons.TRIGGER))){
			transform.parent = grabber1.transform;
			grabbed = true;
		}
		if(grabbed && !SixenseInput.GetController(SixenseHands.LEFT).GetButton(SixenseButtons.TRIGGER) && !SixenseInput.GetController(SixenseHands.LEFT).GetButton(SixenseButtons.TRIGGER)){
			transform.parent = null;
		}
	}
	
	void OnTriggerEnter(Collider other){
		Debug.Log ("entered");
		usable = true;
		grabber1 = other.gameObject;
	}
	
	void OnTriggerExit(Collider other){
		Debug.Log ("left");
		usable = false;
		grabber1 = null;
	}
	
	void OnCollisionStay(Collision other){
		Debug.Log ("whatsup");
		usable = true;
	}
}