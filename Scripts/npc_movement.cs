using UnityEngine;
using System.Collections;

public class npc_movement : MonoBehaviour {
	public float speed = 11;
	public GameObject target;
	public float yAxisLevel = 0f;
	Animator anim;
	bool facingRight = true;

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		target = GameObject.FindGameObjectWithTag ("Player");
		float dist = Vector3.Distance(target.transform.position, transform.position);

		anim.SetFloat ("speed", speed);

		if (dist < 1.5) {
			transform.position = new Vector3(0,0,0);
		}



			float lol = Mathf.Sin(Time.time);
			transform.position = new Vector3(lol*11, yAxisLevel, 0); 
			

		if(transform.position.x > 10.8 && facingRight){
			Flip();
		}
		else if(transform.position.x < -10.8 && !facingRight){
			Flip();
		}
	}

	


	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

}
