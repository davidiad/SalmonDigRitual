using UnityEngine;
using System.Collections;

public class TailFlip : MonoBehaviour {

	public float forceAmt;
	public float forceRadius;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
		if (Input.GetKey ("down")) {
			Vector3 flip = new Vector3(124.0f, 13.6f, 99.8f);
			//rb.AddForce (12230.0f * Vector3.down);
			rb.AddTorque(12230.0f * Vector3.right);
		}
	}
}