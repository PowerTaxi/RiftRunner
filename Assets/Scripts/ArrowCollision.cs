using UnityEngine;
using System.Collections;

public class ArrowCollision : MonoBehaviour {
	private Animation doorAnim;
	int targetamount;
	float depth = 3.0f;
	GameObject door;
	void Start () {
		door = GameObject.Find ("ArrowDoor");
		doorAnim = door.GetComponent<Animation> ();
		targetamount = 0;
	
	}
	void Update()
	{

	}
	
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Arrow") 
		{

			targetamount++;
			Debug.Log("Target hit" + targetamount);
			col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
			col.transform.Translate(depth * Vector3.forward);
			col.transform.parent = transform;

			if(targetamount == 3)
			{
				doorAnim.Play("ArrowDoorOpen");
			}
			
		}
	}

}
