using UnityEngine;
using System.Collections;

public class TryRotation : MonoBehaviour {
	bool stop;

	void Start () {
		stop = false;
	}
	void Update() {
		if (Input.GetKeyDown (KeyCode.E)){
			Nein ();
		}
	}
	void Nein(){
		do {
			transform.Rotate(new Vector3 (0f, 0.5f, 0f));
			if(transform.rotation.eulerAngles.y == 45){
				stop = true;
			}
		} while(stop == false);
	}
}