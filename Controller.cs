﻿using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	private Vector3 movementVector;
	private CharacterController characterController;
	private float movementSpeed = 8;
	private float jumpPower = 15;
	private float gravity = 40;

	void Start () {
		characterController = GetComponent<CharacterController>();
	}

	void Update () {
		movementVector.x = Input.GetAxis("LeftJoystickX") * movementSpeed;
		movementVector.z = Input.GetAxis("LeftJoystickZ") * movementSpeed;

		if (characterController.isGrounded) {
			movementVector.y = 0;

			if (Input.GetButtonDown("A")) {
				movementVector.y = jumpPower;
			}
		}
		movementVector.y -= gravity * Time.deltaTime;
		characterController.Move(movementVector * Time.deltaTime);
	}
}