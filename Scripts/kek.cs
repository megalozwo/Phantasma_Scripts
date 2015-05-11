using UnityEngine;
using System.Collections;


public class kek : MonoBehaviour
{

	public float walkSpeed = 1.0f;
	public float wallLeft = 0.0f;
	public float wallRight = 5.0f;
	
	float walkingDirection = 1.0f;
	Vector3 walkAmount;
	public float currentStatus = 0.0f;
	public float myTimer = 10;

	public float distanceTravel = 0;
	public float totalTravel = 0;
	Vector3 lastpos;


		// Use this for initialization
		void Start ()
		{
		lastpos = transform.position;
		}
	
		// Update is called once per frame
		void Update ()
		{
		distanceTravel += Vector3.Distance(transform.position, lastpos);
		totalTravel += distanceTravel; 
		lastpos = transform.position;


		//print ("Distance: " + distanceTravel);
		//print ("Total: " + totalTravel);


		if (transform.position.x == 0) {
			print ("HAHAHHA");


			while (myTimer > 0 ) {
				transform.position = new Vector3(0,0,0);
				myTimer -= Time.deltaTime;


			}


		}

		else {


		walkAmount.x = walkingDirection * walkSpeed * Time.deltaTime;
		
		if (walkingDirection > 0.0f && transform.position.x >= wallRight)
			walkingDirection = -1.0f;
		else if (walkingDirection < 0.0f && transform.position.x <= wallLeft)
			walkingDirection = 1.0f;
		
	//	transform.Translate(walkAmount);
	
		}
	}

	void OnMouseOver()
	{
		print ("TROLLOL");

		if (Input.GetMouseButtonDown(1))
		{
			rigidbody2D.AddForce(Vector2.up * 100);

		}
		if (Input.GetMouseButtonDown(0))
		{
			rigidbody2D.AddForce(Vector3.forward * 200);

		}
		
	}

	void OnCollisionEnter2D(Collision2D theCollision){
		if(theCollision.gameObject.name == "moo"){

			if ( totalTravel > 500) {
				print("E MALAKA");
				Destroy (gameObject);
				
			}
		}else {
			print("Den psinomai");
		}


}
}
