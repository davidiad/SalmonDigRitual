using UnityEngine;
using System.Collections;

public class MoveWithKeys : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.A)) {
		//if (Input.GetKeyDown(KeyCode.A)) {
			transform.Translate(Vector3.left * speed * Time.fixedDeltaTime);
		}
		if (Input.GetKey(KeyCode.D)) {
			//if (Input.GetKeyDown(KeyCode.A)) {
			transform.Translate(Vector3.right * speed * Time.fixedDeltaTime);
		}
		if (Input.GetKey(KeyCode.W)) {
			//if (Input.GetKeyDown(KeyCode.A)) {
			transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
		}
		if (Input.GetKey(KeyCode.S)) {
			//if (Input.GetKeyDown(KeyCode.A)) {
			transform.Translate(Vector3.back * speed * Time.fixedDeltaTime);
		}

	
	}
}
