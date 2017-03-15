using UnityEngine;
using System.Collections;

public class TargetMove : MonoBehaviour {

	private Animation TargetAmin;
	// Use this for initialization
	void Start () {
		TargetAmin = GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "AnimationTrigger") 
		{
			TargetAmin.Play("TargetRight");
		}

	}
}
