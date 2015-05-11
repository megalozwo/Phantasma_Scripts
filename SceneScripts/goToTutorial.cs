using UnityEngine;
using System.Collections;

public class goToTutorial : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Application.LoadLevel("Tutorial");

	
	}
	
	// Update is called once per frame
	void Update () {

		//if (Input.GetMouseButtonDown(1)) 
		//	Application.LoadLevel("Tutorial");

	//	UIEventListener.Get("startb").onClick += YourClickCallback;

}

	void OnClick() {
		Application.LoadLevel("Tutorial");
	}
}
