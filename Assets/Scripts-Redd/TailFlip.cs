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

	void FixedUpdate () {
		if (Input.GetKey ("down")) {
			//Vector3 flip = new Vector3(124.0f, 13.6f, 99.8f);
			//rb.AddForce (12230.0f * Vector3.down);
			rb.AddTorque(92230.0f * Vector3.forward);
		} else if (Input.GetKey ("up")) {
			rb.AddTorque(-29999.0f * Vector3.forward);

			Collider[] gravels = Physics.OverlapSphere(transform.position, forceRadius);
			Debug.Log(gravels.Length);
			foreach (Collider gravel in gravels) {
				if(gravel.attachedRigidbody) {
					gravel.attachedRigidbody.AddExplosionForce(forceAmt, transform.position, forceRadius);
					gravel.attachedRigidbody.AddForce(-4.0f * Vector3.right);
				}
			}
		}
	}

	//void FixedLateUpdate

}