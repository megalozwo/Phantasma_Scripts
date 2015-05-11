using UnityEngine;
using System.Collections;

public class event1 : MonoBehaviour {
	public GameObject target;
	public GameObject yolo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		target = GameObject.FindGameObjectWithTag ("event1");
		float dist = Vector3.Distance(target.transform.position, transform.position);
		
		if (dist < 1.45 && Input.GetMouseButtonDown(0)) {

			yolo = GameObject.FindGameObjectWithTag ("cubelift");
			yolo.transform.Translate (0.05f,0,0);
			print("Distance to other: " + dist);
		}
	
	}
}
