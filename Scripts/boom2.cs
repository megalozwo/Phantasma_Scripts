using UnityEngine;
using System.Collections;

public class boom2 : MonoBehaviour
{
	private Vector3 originPosition;
	private Vector3 targetPosition;
	private Quaternion originRotation;

	public float shake_decay;
	public float shake_intensity;

	public float lift_intensity;
	public float lift_decay;

	public float fall_intensity;
	public float fall_decay;

	public int pcounter = 0;
	public float timer = 0;

	public float liftSpeed = 2.0f;
	public float fallSpeed = 4.0f;
	public float wallLeft =  0.0f;
	public float wallRight = 10.0f;
	float walkingDirection = 1.0f;
	Vector3 walkAmount;

	public Transform target;
	public float speed = 3;



		// Use this for initialization
		void Start ()
		{

		}
	
		// Update is called once per frame
		void Update ()
		{
		if (pcounter ==3) {
		if (fall_intensity > 0) {

			fall_intensity -= fall_decay;
			walkAmount.y = -1.0f * fallSpeed * Time.deltaTime;

			
			transform.Translate(walkAmount);
				if(fall_intensity <= 0) {

					Destroy (gameObject);
				}

		}
		}


		if (pcounter == 1 ) {

		if (shake_intensity > 0){
			transform.position = originPosition + Random.insideUnitSphere * shake_intensity;
			transform.rotation = new Quaternion(
				originRotation.x + Random.Range (-shake_intensity,shake_intensity) * .2f,
				originRotation.y + Random.Range (-shake_intensity,shake_intensity) * .2f,
				originRotation.z + Random.Range (-shake_intensity,shake_intensity) * .2f,
				originRotation.w + Random.Range (-shake_intensity,shake_intensity) * .2f);
			shake_intensity -= shake_decay;

				if(shake_intensity <= 0) {
					pcounter = 0;
				}
		}
	
		}


		if (pcounter == 2) {

			if (lift_intensity > 0) {
				
				lift_intensity -= lift_decay;
				walkAmount.y = walkingDirection * liftSpeed * Time.deltaTime;
				
				if (walkingDirection > 0.0f && transform.position.y >= wallRight)
					walkingDirection = -1.0f;
				else if (walkingDirection < 0.0f && transform.position.y <= wallLeft)
					walkingDirection = 0f;
				
				transform.Translate(walkAmount);
				if(lift_intensity <= 0) {
					pcounter = 0;
				}
				
			}
			}


		}


	void Shake(){
		originPosition = transform.position;
		originRotation = transform.rotation;
		shake_intensity = .3f;
		shake_decay = 0.001f;
	}

	void Lift() {

		lift_intensity = .5f;
		lift_decay = 0.001f;


	}

	void Exterminate() {
		fall_intensity = 5f;
		fall_decay = 0.02f;

	}

	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(1))
		{

			if (pcounter >=0) {
			Shake();
			Lift ();
			Exterminate (); 

			pcounter = pcounter + 1;
			print (pcounter);
			}
			if (pcounter > 3) {
				pcounter = 0;
			}

			
		}
		
	}
}

