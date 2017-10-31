using UnityEngine;
using System.Collections;

public class Aiming : MonoBehaviour {
	public GameObject crosshair, cam;
	Vector3 vec;

	void Start () {
		crosshair.SetActive(false);
		cam = GameObject.FindGameObjectWithTag("mainCam");
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse1)) {
			vec = cam.transform.localPosition;
			cam.transform.localPosition = new Vector3 (0.4f, 1.75f, -0.75f);
			crosshair.SetActive(true);
		} else if (Input.GetKeyUp (KeyCode.Mouse1)) {
			cam.transform.localPosition = vec;
			crosshair.SetActive(false);
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel ("MainLevel");
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}
	}
}