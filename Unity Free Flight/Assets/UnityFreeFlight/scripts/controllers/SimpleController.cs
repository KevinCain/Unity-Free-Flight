﻿using UnityEngine;
using System.Collections;

public class SimpleController : BaseController {

	Vector3 keyInput;
	

	void Update() {
		//Pitch
		keyInput.x = -Input.GetAxis ("Vertical") * (_rotationSpeed * Time.deltaTime);
		//Roll
		keyInput.z = -Input.GetAxis ("Horizontal") * (_rotationSpeed * Time.deltaTime);
		//Yaw
		//	keyInput.y = Input.GetAxis("Yaw") * (_rotationSpeed * Time.deltaTime);
		_userInput.eulerAngles = keyInput;

	}

}
