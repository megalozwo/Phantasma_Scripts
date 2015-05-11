using UnityEngine;
using System.Collections;

public class telekinisis : MonoBehaviour {

	public int pcounter = 0;
	private Vector3 originPosition;
	private Vector3 targetPosition;
	private Quaternion originRotation;

	public GameObject target2;

	public float shake_decay;
	public float shake_intensity;

	public int chain = 0;

	public float lift_intensity;
	public float lift_decay;


	public float liftSpeed = 2.0f;
	public float fallSpeed = 4.0f;
	public float limitdown =  0.0f;
	public float limitup = 10.0f;
	float liftDirection = 1.0f;
	Vector3 liftAmount;
	
	public Transform target;
	public float speed = 3;
	public AudioClip breakSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



		target2 = GameObject.FindGameObjectWithTag ("Player");


		if (pcounter == 1 ) {
			if (chain <1)
			chain++;
			
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

			if (pcounter == 2) {
				
				if (lift_intensity > 0) {
					
					lift_intensity -= lift_decay;
					rigidbody2D.AddForce(Vector2.up * 300);

					if(lift_intensity <= 0) {
						pcounter = 0;
					}
					
				}
			}

			if (pcounter >= 3)
				Destroy (gameObject);
				
				
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
		lift_decay = 0.1f;

	}
	
	void Exterminate() {

		
	}



	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(1))
		{

			Shake();
			pcounter = pcounter + 1;
			print (pcounter);
			
			//if (pcounter > 2) {
			//	pcounter = 0;
			//}
		}
		
	}
}
