using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMovePos : MonoBehaviour {
	public GameObject cam;

	void Update () {
		if (Input.GetAxis("Mouse ScrollWheel") > 0f) {
			Invoke("ScrollUp", 0f);
		}
		if (Input.GetAxis("Mouse ScrollWheel") < 0f) {
			Invoke("ScrollDown", 0f);
		}
	}

	void ScrollUp() {
		//Debug.Log("Up");
		if (cam.transform.localPosition.z < -1f) {
			cam.transform.Translate(Vector3.forward);
		} else if (cam.transform.localPosition.z > -1.01f && cam.transform.localPosition.z < -0.95f) {
			cam.transform.localPosition = new Vector3(cam.transform.localPosition.x, cam.transform.localPosition.y, 0f);
		}
	}

	void ScrollDown() {
		//Debug.Log("Down");
		if (cam.transform.localPosition.z > -5f) {
			cam.transform.Translate(Vector3.back);
		}
	}
}
