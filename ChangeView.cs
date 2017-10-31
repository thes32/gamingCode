using UnityEngine;
using System.Collections;

public class ChangeView : MonoBehaviour {
	GameObject cam;
	int camPos;

	void Start () {
		cam = GameObject.FindGameObjectWithTag ("mainCam");
		camPos = 1;
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			if (camPos == 1) {
				cam.transform.localPosition = new Vector3 (0f, 1.75f, -4f);
				camPos = 2;
			} else if (camPos == 2) {
				cam.transform.localPosition = new Vector3 (0f, 1.75f, -5f);
				camPos = 3;
			} else if (camPos == 3) {
				cam.transform.localPosition = new Vector3 (0f, 1.75f, -2.5f);
				camPos = 1;
			}
		}
	}
}