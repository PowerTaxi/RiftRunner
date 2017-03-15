using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Require a character controller to be attached to the same game object
[RequireComponent(typeof(CharacterMotor))]
[AddComponentMenu("Character/FPS Input Controller")]

public class FPSInputController : MonoBehaviour
{
    private CharacterMotor motor;
	private bool inputEnabled;

    // Use this for initialization
    void Awake()
    {
        motor = GetComponent<CharacterMotor>();
    }
	void Start()
	{
		//ignorePlayerColliders ();
		inputEnabled = true;

	}
    // Update is called once per frame
    void Update()
    {
        // Get the input vector from kayboard or analog stick
        Vector3 directionVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		//Get input Hydra
		SixenseInput.Controller hydraLeftController = SixenseInput.GetController (SixenseHands.LEFT);
		SixenseInput.Controller hydraRightController = SixenseInput.GetController (SixenseHands.RIGHT);

		if (hydraLeftController != null) {
			directionVector = new Vector3 (hydraLeftController.JoystickX, 0, hydraLeftController.JoystickY);

		}

		if (hydraRightController != null) {
			motor.inputJump = hydraLeftController.GetButton (SixenseButtons.JOYSTICK);
		
		} else {
			motor.inputJump = Input.GetButton("Jump");
		}


        motor.inputMoveDirection = transform.rotation * directionVector;
        
    }

	public void SetInputEnabled(bool status){
		inputEnabled = status;
	}

	void ignorePlayerColliders(){
		Collider[] cols = GetComponentsInChildren<Collider>();
		foreach(Collider col in cols){
			if(col != GetComponent<Collider>())
				Physics.IgnoreCollision(col, GetComponent<Collider>());
		}
	}
	
}