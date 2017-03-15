using UnityEngine;
using System.Collections;

public class BowScript : MonoBehaviour {
	Renderer bowrender;
	Animation bowanim;
	private int i = 0;
	private int n = 10;
	private int t = 0;
	private int t1 = 0;
	float speed = 0.1f;
	public Transform arrowp;
	public GameObject projectile;
	bool triggered;
	public GameObject arrow1, arrow2, arrow3, arrow4, arrow5, arrow6, arrow7, arrow8, arrow9, arrow10, arrow11;
	
	void Start () {

		arrow6.GetComponent<Renderer> ().enabled = false;

		bowanim = GetComponent<Animation> ();

	}
	
	// Update is called once per frame
	void OnTriggerStay(Collider col) 
	{
		triggered = true;
		t = 1 + (int) Time.fixedTime;
		if (this.GetComponent<GrabBow> ().grabbed) {
			if (SixenseInput.GetController (SixenseHands.LEFT).GetButtonDown (SixenseButtons.TRIGGER)) {
				if (n > 0) {
					if (i < 1) 
					{
						i = 1;
						arrowshoot ();
						t1 = t;
						if (!bowanim.isPlaying)
							bowanim.Play ("Armature_002Action");
						arrow6.GetComponent<Renderer> ().enabled = true;

					}
				}
				if (n > 0) 
				{
					if (t - t1 > 4) 
					{
						if (i > 0) 
						{
							i = 2;
							if (!bowanim.isPlaying)
								bowanim.Play ("Armature_002Actio_001");
							i = 0;
							n = n - 1;
							GameObject instantiatedProjectile;
							instantiatedProjectile = Instantiate (projectile, arrowp.transform.position, transform.rotation) as GameObject;
							instantiatedProjectile.GetComponent<Rigidbody> ().velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
							t1 = 1;
							arrow6.GetComponent<Renderer> ().enabled = false;
						}
					}

				}
			}
		}
	}

	void OnTriggerExit()
	{
		triggered = false;
	}
	
	void onGUI()
	{
		if (triggered = true) {
			GUI.contentColor = Color.red;  
			GUI.Label (new Rect (10, 100, 350, 20), "Pull back the string and release to fire arrows!.");
		}
	}

	void arrowshoot()
	{
		if (n == 0) 
		{
			arrow1.GetComponent<Renderer>().enabled=false;
			arrow2.GetComponent<Renderer>().enabled=false;
			arrow3.GetComponent<Renderer>().enabled=false;
			arrow4.GetComponent<Renderer>().enabled=false;
			arrow5.GetComponent<Renderer>().enabled=false;
		}
		if (n == 1) 
		{
			arrow1.GetComponent<Renderer>().enabled=false;
			arrow2.GetComponent<Renderer>().enabled=false;
			arrow3.GetComponent<Renderer>().enabled=false;
			arrow4.GetComponent<Renderer>().enabled=false;
			arrow5.GetComponent<Renderer>().enabled=false;
		}
		if (n == 2) 
		{
			arrow1.GetComponent<Renderer>().enabled=true;
			arrow2.GetComponent<Renderer>().enabled=false;
			arrow3.GetComponent<Renderer>().enabled=false;
			arrow4.GetComponent<Renderer>().enabled=false;
			arrow5.GetComponent<Renderer>().enabled=false;
		}
		if (n == 3) 
		{
			arrow1.GetComponent<Renderer>().enabled=true;
			arrow2.GetComponent<Renderer>().enabled=true;
			arrow3.GetComponent<Renderer>().enabled=false;
			arrow4.GetComponent<Renderer>().enabled=false;
			arrow5.GetComponent<Renderer>().enabled=false;
		}
		if (n == 4) 
		{
			arrow1.GetComponent<Renderer>().enabled=true;
			arrow2.GetComponent<Renderer>().enabled=true;
			arrow3.GetComponent<Renderer>().enabled=true;
			arrow4.GetComponent<Renderer>().enabled=false;
			arrow5.GetComponent<Renderer>().enabled=false;
		}

		if (n >= 5) 
		{
			arrow1.GetComponent<Renderer>().enabled=true;
			arrow2.GetComponent<Renderer>().enabled=true;
			arrow3.GetComponent<Renderer>().enabled=true;
			arrow4.GetComponent<Renderer>().enabled=true;
			arrow5.GetComponent<Renderer>().enabled=false;
		}
	}

}