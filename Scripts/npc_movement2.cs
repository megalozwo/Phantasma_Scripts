using UnityEngine;
using System.Collections;

public class npc_movement2 : MonoBehaviour {

	public float speed = 11;
	public GameObject target;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		target = GameObject.FindGameObjectWithTag ("Player");
		float dist = Vector3.Distance(target.transform.position, transform.position);
		
		
		
		if (dist < 1.5) {
			transform.position = new Vector3(0,0,0);
		}
		
		
		
		float lol = Mathf.Sin(Time.time);
		transform.position = new Vector3(lol*11, 5.5f, 0); 
		
		
	}

}
