using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	public Vector3 BowSpawnPoint;
	public GameObject bow;
	public GameObject bowSpawn;
	public GameObject respawnPoint;
	SixenseInput.Controller hydraLeftController = SixenseInput.GetController (SixenseHands.LEFT);

	// Use this for initialization
	void Start () {
		bowSpawn = GameObject.Find ("BowSpawn");
		BowSpawnPoint = bowSpawn.transform.position;
		respawnPoint = GameObject.Find ("RespawnPoint");
	}

	void Update()
	{

	}
	void OnTriggerEnter(Collider col) 
	{
		if (col.gameObject.tag == "RespawnTrigger") {
			this.transform.position = respawnPoint.transform.position;
			Debug.Log ("Should Respawn");
		}
	}
	

}
