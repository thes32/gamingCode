using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRotate : MonoBehaviour {
	GameObject cam;
	bool two;

	void Start () {
		cam = GameObject.Find ("MainCam");
		two = false;
	}

	void Update () {
		
		if (Input.GetKey (KeyCode.W) && two == false) {
			transform.eulerAngles = new Vector3 (0, cam.transform.rotation.eulerAngles.y, 0);
			//transform.Translate(Vector3.forward * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.S) && two == false) {
			transform.eulerAngles = new Vector3 (0, cam.transform.rotation.eulerAngles.y + 180, 0);
			//transform.Translate(Vector3.forward * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.D) && two == false){
			transform.eulerAngles = new Vector3 (0, cam.transform.rotation.eulerAngles.y + 90, 0);
			//transform.Translate(Vector3.forward * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.A) && two == false){
			transform.eulerAngles = new Vector3 (0, cam.transform.rotation.eulerAngles.y - 90, 0);
			//transform.Translate(Vector3.forward * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.D) && Input.GetKey (KeyCode.W)){
			transform.eulerAngles = new Vector3 (0, cam.transform.rotation.eulerAngles.y + 45, 0);
			two = true;
		}
		if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.W)){
			transform.eulerAngles = new Vector3 (0, cam.transform.rotation.eulerAngles.y - 45, 0);
			two = true;
		}
		if (Input.GetKey (KeyCode.D) && Input.GetKey (KeyCode.S)){
			transform.eulerAngles = new Vector3 (0, cam.transform.rotation.eulerAngles.y - 45 - 180, 0);
			two = true;
		}
		if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.S)){
			transform.eulerAngles = new Vector3 (0, cam.transform.rotation.eulerAngles.y + 45 + 180, 0);
			two = true;
		}


		if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.S)) {
			two = false;
		}
	}
}