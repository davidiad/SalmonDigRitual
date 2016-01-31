using UnityEngine;
using System.Collections;

public class DampenFishVelocity : MonoBehaviour {

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		//rigidbody rb = GetComponent<Rigidbody>()
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity *= 0.8f;
		
	}
}
