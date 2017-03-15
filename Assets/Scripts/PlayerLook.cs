using UnityEngine;
using System.Collections;

[AddComponentMenu("Camera-Control/Player Look")]

public class PlayerLook : MonoBehaviour {
	public enum RotationAxes { XAndY = 0, X = 1, Y = 2 }
	public RotationAxes axes = RotationAxes.XAndY;
	public float sensitivityX = 1F;
	public float sensitivityY = 1F;
	
	public float minimumX = -360F;
	public float maximumX = 360F;
	
	public float minimumY = -60F;
	public float maximumY = 60F;
	
	float rotationX = 0F;
	float rotationY = 0F;
	Quaternion originalRotation;

	protected float axisX, axisY;




	// Use this for initialization
	void Start () {
		if (GetComponent<Rigidbody>())
			GetComponent<Rigidbody>().freezeRotation = true;
		originalRotation = transform.localRotation;
	}
	
	// Update is called once per frame
	 protected virtual void Update () {

		rotationX += 0.05f* axisX * sensitivityX;
		rotationY += 0.05f* axisY * sensitivityY;
		
		rotationX = Mathf.Clamp (rotationX, minimumX, maximumX);
		rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
		
		Quaternion xQuaternion = Quaternion.AngleAxis (rotationX, Vector3.up);
		Quaternion yQuaternion = Quaternion.AngleAxis (rotationY, -Vector3.right);
		
		transform.localRotation = originalRotation * xQuaternion * yQuaternion;

			

	
	}
}
