using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {
	public Animator anim;
	GameObject cam;
	static float speed;

	void Start () {
		anim = GetComponent<Animator>();
		cam = GameObject.Find ("MainCam");
		speed = 10;
		Cursor.visible = false;
	}

	void Update () {
		//animaiton stuff
		if (Input.GetKeyDown (KeyCode.W)) {
			if (Input.GetKey (KeyCode.LeftControl)) {
				//do nothing
			} else {
				anim.Play ("HumanoidRun", -1, 0f);
			}
		}
		if (Input.GetKeyUp (KeyCode.W)) {
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.D)) {
				//do nothing
			} else {
				anim.Play ("HumanoidIdle", -1, 0f);
			}
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			anim.Play ("HumanoidRun", -1, 0);
		}
		if (Input.GetKeyUp (KeyCode.S)) {
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.D)) {
				//do nothing
			} else {
				anim.Play ("HumanoidIdle", -1, 0);
			}
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			if (Input.GetKey (KeyCode.LeftControl)){
				//do nothing
			} else {
				anim.Play ("HumanoidRun", -1, 0f);
			}
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.S)) {
				//do nothing
			} else {
				anim.Play ("HumanoidIdle", -1, 0f);
			}
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			if (Input.GetKey (KeyCode.LeftControl)){
				//do nothing
			} else {
				anim.Play ("HumanoidRun", -1, 0f);
			}
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.S)) {
				//do nothing
			} else {
				anim.Play ("HumanoidIdle", -1, 0f);
			}
		}
		if (Input.GetKey (KeyCode.W) && Input.GetKeyDown (KeyCode.LeftControl)) {
			anim.Play ("HumanoidWalk", -1, 0f);
		}
		if (Input.GetKey (KeyCode.W) && Input.GetKeyUp (KeyCode.LeftControl)) {
			anim.Play ("HumanoidRun", -1, 0f);
		}
		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.D) && Input.GetKeyDown (KeyCode.LeftControl)) {
			anim.Play ("HumanoidWalk", -1, 0f);
		}
		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.D) && Input.GetKeyUp (KeyCode.LeftControl)) {
			anim.Play ("HumanoidRun", -1, 0f);
		}
		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.A) && Input.GetKeyDown (KeyCode.LeftControl)) {
			anim.Play ("HumanoidWalk", -1, 0f);
		}
		if (Input.GetKeyDown (KeyCode.LeftControl) && Input.GetKey (KeyCode.D)) {
			anim.Play ("HumanoidWalk", -1, 0f);
		}
		if (Input.GetKeyDown (KeyCode.LeftControl) && Input.GetKey (KeyCode.A)) {
			anim.Play ("HumanoidWalk", -1, 0f);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			anim.Play ("HumanoidJumpUpRun", -1, 0);
		}
	}
}