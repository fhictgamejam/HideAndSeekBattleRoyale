using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingEnter : MonoBehaviour {

	public GameObject roof;
	public Camera cam;
	public float resizeToSize = 15;
	private float cameraSize;

	private void Start()
	{
		cameraSize = cam.orthographicSize;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			roof.GetComponent<Renderer>().enabled = false;
			cam.orthographicSize = resizeToSize;
		}
	}
	private void OnTriggerExit(Collider other)
	{
		roof.GetComponent<Renderer>().enabled = true;
		cam.orthographicSize = cameraSize;
	}
}
