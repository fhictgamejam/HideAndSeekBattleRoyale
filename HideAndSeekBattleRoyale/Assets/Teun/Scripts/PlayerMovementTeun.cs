using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class PlayerMovementTeun : NetworkBehaviour {

	public Camera cam;

	public float speed = 10.0f;

	void Start()
	{
		if (isLocalPlayer) {
			return;
		} 
		else {
			cam.enabled = false;
		}
	}

	void Update(){

		if (!isLocalPlayer) {
			return;
		}

		float Xtranslation = CrossPlatformInputManager.GetAxis ("Horizontal") * speed * Time.deltaTime;
		float Ytranslation = CrossPlatformInputManager.GetAxis ("Vertical") * speed * Time.deltaTime;
		transform.Translate (Xtranslation, Ytranslation, 0);
	}
}
