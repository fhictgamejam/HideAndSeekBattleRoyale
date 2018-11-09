using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraController : NetworkBehaviour {


	public Vector3 Offset;

	Camera PlayerCamera;

	// Use this for initialization
	void Start () {
		PlayerCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		PlayerCamera.transform.position = gameObject.transform.position + Offset;
	}

	void OnStartClient()
	{
		
	}
}
