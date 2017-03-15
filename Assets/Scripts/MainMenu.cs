using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public bool isRiftCal;
	public bool isTut;
	public bool isStart;
	public bool isQuit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("1"))
			Application.LoadLevel(1);
		if(Input.GetKeyDown("2"))
			Application.LoadLevel(2);
		if(Input.GetKeyDown("3"))
			Application.LoadLevel(3);
		if(Input.GetKeyDown("q"))
		   Application.Quit();
	
	}

	void OnMouseUp(){
		if(isRiftCal)
		{
			Application.LoadLevel(1);
		}

		if(isStart)
		{
			Application.LoadLevel(2);
		}

		if (isQuit)
		{
			Application.Quit();
		}
	} 
}
