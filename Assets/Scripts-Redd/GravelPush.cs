using UnityEngine;
using System.Collections;

public class GravelPush : MonoBehaviour {

	public float forceAmt;
	public float forceRadius;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("space")) {
			Collider[] gravels = Physics.OverlapSphere(transform.position, forceRadius);
			Debug.Log(gravels.Length);
			foreach (Collider gravel in gravels) {
				if(gravel.attachedRigidbody) {
					gravel.attachedRigidbody.AddExplosionForce(forceAmt, transform.position, forceRadius);
				}
			}
		}
	}
}
