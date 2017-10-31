using UnityEngine;
using System.Collections;

public class FinalAnimations : MonoBehaviour {
	
	public Animator anim;
	GameObject cam;

	void Start () {
		anim = GetComponent<Animator>();
		cam = GameObject.Find ("CameraMain");
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			transform.eulerAngles = new Vector3 (0, cam.transform.rotation.eulerAngles.y, 0);
			anim.Play ("HumanoidWalk", -1, 0f);
		}
		if (Input.GetKeyUp (KeyCode.W)) {
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.D)){
				//do nothing
			} else {
				anim.Play ("HumanoidIdle", -1, 0f);
			}
		}
		if (Input.GetKey (KeyCode.W)) {
			if (Input.GetKeyDown (KeyCode.D)){
				anim.Play ("HumanoidWalkRight", -1, 0);
			}
			if (Input.GetKeyUp (KeyCode.D)){
				anim.Play ("HumanoidWalkLeft", -1, 0);
			}
			if (Input.GetKeyDown (KeyCode.A)){
				anim.Play ("HumanoidWalkLeft", -1, 0);
			}
			if (Input.GetKeyUp (KeyCode.A)){
				anim.Play ("HumanoidWalkRight", -1, 0);
			}
		} else {
			anim.Play ("HumanoidIdle", -1, 0);
		}
	}
}