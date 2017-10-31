using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour {
	GameObject character;

	void Start () {
		character = GameObject.FindGameObjectWithTag("body");
	}

	void Update () {
		transform.position = character.transform.position;
	}
}