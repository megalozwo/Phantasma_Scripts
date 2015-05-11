using UnityEngine;
using System.Collections;

public class Shake : MonoBehaviour {

	private Vector3 originPosition;
	private Quaternion originRotation;
	public float shakeDecay;
	public float shakeIntensity;

	// Use this for initialization
	void Start () {
		Boom ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1) ) {

		if (shakeIntensity > 0) {
			transform.position = originPosition + Random.insideUnitSphere * shakeIntensity;
			transform.rotation = new Quaternion (
				originRotation.x + Random.Range(-shakeIntensity,shakeIntensity)*.2f,
				originRotation.y + Random.Range(-shakeIntensity,shakeIntensity)*.2f,
				originRotation.z + Random.Range(-shakeIntensity,shakeIntensity)*.2f,
				originRotation.w + Random.Range(-shakeIntensity,shakeIntensity)*.2f);
			
			shakeIntensity -= shakeDecay;
		}

		if (shakeIntensity == 0) {
			
		}
		}
	}

	public void Boom(){
		originPosition = transform.position;
		originRotation = transform.rotation;
		shakeIntensity = .1f;
		shakeDecay = 0.002f;
	}
}
