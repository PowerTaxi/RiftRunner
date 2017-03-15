using UnityEngine;
using System.Collections;

public class HydraLook : PlayerLook {

	// Update is called once per frame
	void Update () {
		SixenseInput.Controller hydraRightController = SixenseInput.GetController (SixenseHands.RIGHT);

		if (hydraRightController != null) {
			axisX = hydraRightController.JoystickX;
			axisY = hydraRightController.JoystickY;
		}

		base.Update ();

	}
}
