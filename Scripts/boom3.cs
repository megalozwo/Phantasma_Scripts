using UnityEngine;
using System.Collections;

public class boom3 : MonoBehaviour {

	GameObject player;
	float distance = 0;
	float AttractOn = 0;
    //GameObject target;
	GameObject target2;


	public Transform startMarker;
	public Transform endMarker;
	public float speed = 20.0F;
	private float startTime;
	private float journeyLength;
	public Transform target;
	public float smooth = 1.0F;
	bool clicked=false;
	
	// Use this for initialization
	void Start () {
		//startTime = Time.time;
		//journeyLength = Vector3.Distance(transform.position, target2.position);

	}
	
	// Update is called once per frame
	void Update () {
		target2 = GameObject.Find ("Player");
		transform.LookAt(target2.transform);

		if (clicked) {
			//transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed*Time.deltaTime);
			rigidbody2D.AddForce(Vector2.right* speed);
			//transform.position = Vector3.Lerp(transform.position,target.transform.position,Time.deltaTime*smooth);
		}

		if (Input.GetMouseButtonUp(0)) {
			print ("QQQQ");

		  	//atransform.Translate = new Vector3(target.transform.position.x,  * Time.deltaTime * smooth);
			//print (target.transform.position.x);
			//transform.Translate (target.transform.position.x, target.transform.position.y, 0 );
			//transform.position = Vector3.Lerp(transform.position,target.transform.position,Time.deltaTime*smooth);
			 //transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed*Time.deltaTime);
			clicked = true;
			//float distCovered = (Time.time - startTime) * speed;
			//float fracJourney = distCovered / journeyLength;
			//transform.position = Vector3.Lerp(transform.position, target2.transform.position, fracJourney);
			
			
		}

		if (Input.GetMouseButton (1))
			clicked = false;
		
		
	}


	void OnMouseOver()
	{



		
	}
}
