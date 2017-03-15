using UnityEngine;
using System.Collections;

public class GrabBow: MonoBehaviour {
	public bool grabbed, triggered;
	public GameObject bowObj;
	GameObject handPos;
	
	void Start(){
		handPos = GameObject.FindGameObjectWithTag("RHand");
	}
	
	void Update(){
		if (transform.position.y <= -5) {
			this.transform.parent = null;
		}
		if (grabbed && SixenseInput.GetController(SixenseHands.RIGHT).GetButton(SixenseButtons.ONE)) {
			grabbed = false;
			this.transform.parent = null;
			GetComponent<Rigidbody> ().useGravity = true;
			GetComponent<Rigidbody> ().isKinematic = false;
		}
	}
	
	void OnCollisionStay(Collision other){
		triggered = true;
		if (other.gameObject.tag == "RHand" && SixenseInput.GetController(SixenseHands.RIGHT).GetButton(SixenseButtons.TRIGGER) || other.gameObject.tag == "LHand" && SixenseInput.GetController(SixenseHands.LEFT).GetButton(SixenseButtons.TRIGGER)) {
			transform.SetParent(handPos.transform);
			transform.localPosition = Vector3.zero;
			transform.localRotation = Quaternion.identity;
			transform.Rotate (0,180,-90);
			GetComponent<Rigidbody>  ().useGravity = false;
			GetComponent<Rigidbody> ().isKinematic = true;
			grabbed = true;
		}
	}
	void OnCollisionExit()
	{
		triggered = false;
	}
	
	void onGUI()
	{
		if (triggered = true) {
			GUI.contentColor = Color.red;  
			GUI.Label (new Rect (10, 100, 350, 20), "Grab the bow with your hand.");
		}
	}
}