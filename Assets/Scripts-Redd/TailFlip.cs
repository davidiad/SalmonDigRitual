using UnityEngine;
using System.Collections;

public class TailFlip : MonoBehaviour {

	public float forceAmt;
	public float forceRadius;
	public float streamForceAmt;


	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		if (Input.GetKey ("down")) {
			//Vector3 flip = new Vector3(124.0f, 13.6f, 99.8f);
			//rb.AddForce (12230.0f * Vector3.down);
			float parentalAngle = transform.parent.localEulerAngles.z;
			if (parentalAngle < 10.0f || parentalAngle > 80.0f) {
				rb.AddTorque(9992230.0f * Vector3.forward);
			} else { // limit ability to dig under the terrain
				rb.AddTorque(20.0f * Vector3.forward);
			}
		} else if (Input.GetKey ("up")) {
			rb.AddTorque(-299999.0f * Vector3.forward);

			Collider[] gravels = Physics.OverlapSphere(transform.position, forceRadius);
			//Debug.Log(gravels.Length);
			foreach (Collider gravel in gravels) {
				//if (gravel.tag != "terrain") {
					if(gravel.attachedRigidbody) {
						gravel.attachedRigidbody.AddExplosionForce(forceAmt, transform.position, forceRadius);
						gravel.attachedRigidbody.AddForce(streamForceAmt * Vector3.right);
					}
				//}
			}
		}
	}

	//void FixedLateUpdate

}