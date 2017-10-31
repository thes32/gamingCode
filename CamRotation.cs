using UnityEngine;
using System.Collections;

public class CamRotation : MonoBehaviour {
	public float speedH = 4.0f;
	public float speedV = 4.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;
	private float sens = 90;

	void Update() {
		yaw += speedH * Input.GetAxis ("Mouse X") * Time.deltaTime * sens;
		pitch -= speedV * Input.GetAxis ("Mouse Y") * Time.deltaTime * sens;
		pitch = Mathf.Clamp (pitch, -20, 45);

		transform.eulerAngles = new Vector3 (pitch, yaw, 0.0f);
	}
}