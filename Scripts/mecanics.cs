using UnityEngine;
using System.Collections;

public class mecanics : MonoBehaviour
{
	public Transform other;
	public GameObject target;
	public int scareFactor;
	public int numberOfClues;
	public int chain;
	public int numberOfClicks;

	public bool clue1 = false;
	public bool clue2= false;
	//public bool clue3= false;

	Vector3 mousePosition;


	private float startTime;
	private float Timeleft;


	
	// Use this for initialization
	void Start ()
		{

	    }
	
		// Update is called once per frame
		void Update ()
		{
		if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
			numberOfClicks++;


		if (numberOfClicks == 50)
			Application.LoadLevel("Game_Over");

		if ( numberOfClues == 2 )
			Application.LoadLevel ("Ending");





		Timeleft -= Time.deltaTime;
		if (Timeleft < 0) Timeleft = 0;
		//target = GameObject.FindGameObjectWithTag ("Player");
		target = GameObject.FindGameObjectWithTag ("finder1");
		float dist = Vector3.Distance(target.transform.position, transform.position);

		if (!clue1) {
		if (dist < 1.0 ) {
			Timeleft = 3;
			clue1 = true;
				numberOfClues++;
		print("Distance to other: " + dist);
		}

		}
	}

	void OnGUI () {


		GUI.Button(new Rect (10,10,200,20), "Clues found: " + numberOfClues +"/2") ;
		GUI.Button(new Rect (10,50,200,20), "Scare Factor: " + numberOfClicks);

		if ( Timeleft != 0)
			GUI.Button(new Rect (300,300,200,20), "Clue found!") ;
		
		
	}

	void PointChecker() {

	}

    void OnMouseOver() {
		if(!clue2) {

			Timeleft = 3;
			clue2 = true;
			numberOfClues++;
		}



	}



}

