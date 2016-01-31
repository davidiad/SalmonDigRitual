using UnityEngine;
using System.Collections;

public class StoreMeshVertices : MonoBehaviour {

	public GameObject moundBase;
	public static Vector3[] moundBaseVertices;
	
	void Awake () {

		Mesh mesh = moundBase.GetComponent<MeshFilter>().mesh;
		moundBaseVertices = mesh.vertices;
//		int i = 0;
//		while (i < vertices.Length) {
//			vertices[i] += Vector3.up * Time.deltaTime;
//			i++;
//		}
//		mesh.vertices = vertices;
//		mesh.RecalculateBounds();
	}
	
}