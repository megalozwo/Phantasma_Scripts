using UnityEngine;
using System.Collections;

public class lifttest : MonoBehaviour {


	// Use this for initialization
	void Start()
	{
		print (Time.time);
	}
	
	// Update is called once per frame
	void Update()
	{
	

		transform.position += new Vector3(0, Time.deltaTime * 5f, 0);
	}
}
