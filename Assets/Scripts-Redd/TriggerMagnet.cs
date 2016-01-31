using UnityEngine;
using System.Collections;

public class TriggerMagnet : MonoBehaviour {

	public float forceAmt;
	public float forceRadius;
	public GameObject magnet;

	void OnTriggerEnter(Collider other) {
		// select a random vertex from the stored mound vertices
		Vector3 pos = StoreMeshVertices.moundBaseVertices [4];
		Debug.Log ("STAY");
		if(other.attachedRigidbody) {
			Debug.Log("Hit the wall");
			other.attachedRigidbody.AddExplosionForce(forceAmt, pos, forceRadius);
		}
	}
}