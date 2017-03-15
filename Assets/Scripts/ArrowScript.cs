using UnityEngine;
using System.Collections;

public class ArrowScript : MonoBehaviour {

	public Rigidbody rig;
	int speed = 50;
	public Transform trans;
	private Vector3 vel;
	private Vector3 pos;
	private Vector3 plu;

	// Use this for initialization
	void Start () 
	{
		plu = new Vector3(0,0,2);
		rig = GetComponent<Rigidbody>();
		rig.angularDrag = 0.5f;
		rig.AddForce (-trans.forward * speed, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		pos = trans.position+trans.TransformDirection(plu);
		vel = trans.InverseTransformDirection (rig.velocity);
		vel.z = 0;
		vel = -vel/1000;
		vel = trans.TransformDirection (vel);
		rig.AddForceAtPosition(vel,pos,ForceMode.VelocityChange);
	
	}
}
