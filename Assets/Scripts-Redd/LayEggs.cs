using UnityEngine;
using System.Collections;

public class LayEggs : MonoBehaviour {

	//public ParticleSystem eggs;
	public Transform particleSystem;
	public GameObject ovipositor;
	public GameObject tailParent;

	// Use this for initialization
	void Start () {
		//ps = eggs.GetComponent<ParticleEmitter> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "tail") {
			Debug.Log ("Tail Touch");

//			Rigidbody rb = tail.GetComponent<Rigidbody>();
//
//			rb.AddTorque(-0929999.0f * Vector3.forward);

			//Transform eggLayerTransform = GameObject.FindGameObjectWithTag("tail").transform;

			StartCoroutine(Chill());
			



		}
	}

	IEnumerator Chill() {
		print(Time.time);
		yield return new WaitForSeconds(3);
		var go = Instantiate(particleSystem, ovipositor.transform.position, ovipositor.transform.rotation);
		print(Time.time);
	}
}
