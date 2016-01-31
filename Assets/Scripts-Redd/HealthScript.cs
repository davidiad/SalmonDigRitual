using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public static float health;
	public Text healthText;

	void Awake () {
		health = 100.0f;
		healthText.text = "Health: " + health;
	}

	void OnCollisionEnter (Collision col) {
		health -= 0.1f;
		Debug.Log ("Health: " + health);
		healthText.text = "Health: " + health;
		if (health <= 0.0f) {
			die ();
		}
	}

	void die() {
		healthText.text = "You died!";
	}

//	void FixedUpdate () {
//		Debug.Lo
//	}

}
