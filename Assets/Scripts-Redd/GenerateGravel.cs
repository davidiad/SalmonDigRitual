using UnityEngine;
using System.Collections;
// Instantiates a prefab in a circle

public class GenerateGravel : MonoBehaviour {

public GameObject prefab;
public int numberOfObjects = 20;
public float radius = 5f;

	public int gridX = 10;
	public int gridY = 10;
	public float scale = 1.0f;

void Update() {
		if (Input.GetButtonDown ("Jump")) {
			Vector3 ParentPos = transform.position;
			for (int i = 0; i < gridX; i++) {
				for (int j = 0; j < gridY; j++ ){
					Vector3 pos = ParentPos + new Vector3(i, 0, j) * scale;
					Instantiate (prefab, pos, Quaternion.identity);
				}
			}
		}
	}
}