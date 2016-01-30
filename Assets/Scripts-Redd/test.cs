using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
class test
{
	static test ()
	{
		EditorApplication.update += Update;
	}
	
	static void Update ()
	{
		//Debug.Log("Updating");
	}
}