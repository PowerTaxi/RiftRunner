using UnityEngine;
using System.Collections;

public class GrabObject : MonoBehaviour {
	SixenseInput.Controller hydraLeftController = SixenseInput.GetController (SixenseHands.LEFT);
	SixenseInput.Controller hydraRightController = SixenseInput.GetController (SixenseHands.RIGHT);
	public GameObject hand;
	private GameObject grabbedObject = null;
	private Transform objectOrgParent = null;

	void OnCollisionStay(Collision collision){
		if (hydraLeftController.GetButton (SixenseButtons.TRIGGER) == true) {

			grabbedObject = collision.gameObject;
			grabbedObject.GetComponent<Rigidbody>().isKinematic = true;  
			objectOrgParent = grabbedObject.transform.parent;
			grabbedObject.transform.parent = hand.transform;

		}
	}

	void FixedUpdate(){
		if (grabbedObject != null) {
			if (hydraLeftController.GetButton (SixenseButtons.TRIGGER) == false) {
				grabbedObject.transform.parent = objectOrgParent;
				grabbedObject.GetComponent<Rigidbody>().isKinematic = false;  

				grabbedObject = null;
			}
		}
	}
}




//	public bool isEnabled = true;
//	public bool invertRightHand = true;
//	public Vector3 positionModifier = new Vector3(0,0,0);
//	public Vector3 rotationModifier = new Vector3(0,0,0);
//	public Vector3  invertRotationModifier = new Vector3();
//	private Vector3 defaultPositionModifier = new Vector3(0, 0, 0);
//	private Vector3 defaultRotationModifier = new Vector3(-180,180,0);
//
//	public Vector3 GetPosition(SixenseHands Hand){
//		if (Hand == SixenseHands.LEFT || Hand == SixenseHands.RIGHT) {
//			return positionModifier;
//		}
//		return defaultPositionModifier;
//	}
//
//	public Vector3 GetRotation(SixenseHands Hand){
//		if (Hand == SixenseHands.LEFT || (Hand == SixenseHands.RIGHT && !invertRightHand)) {
//			return rotationModifier;
//		}
//
//		if (Hand == SixenseHands.RIGHT) {
//			return rotationModifier + invertRotationModifier;
//		}
//
//		return defaultRotationModifier;
//	}

