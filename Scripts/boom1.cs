using UnityEngine;
using System.Collections;

public class boom1 : MonoBehaviour {

	float speed = 10.0f; //how fast it shakes
	bool  sChecker = false;
	float countdown;

	
	float amount = 1.0f; //how much it shakes

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Mathf.Sin(Time.time * speed), 0, 0);
					
		if(sChecker == true)
		{
			//transform.position = new Vector3(Mathf.Sin(Time.time * speed), 0, 0);
			transform.position = new Vector3(Mathf.PingPong(0, 3), 0, 0);
			//transform.position = new Vector3(-1, 0, 0);

			countdown -= Time.deltaTime;

			if(countdown <= 0)
			{
				//Do your stuff
				sChecker = false;
			}
		}
	
	}

	void StartTime(float time) {
		sChecker = true;
		countdown = time;

	}

	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(1))
		{
			StartTime(5);
			sChecker = true;
			// float qq = Mathf.Sin(Time.time * speed);
			//transform.position = new Vector3(Mathf.Sin(Time.time * speed), 0, 0);

		}
		
	}
}
