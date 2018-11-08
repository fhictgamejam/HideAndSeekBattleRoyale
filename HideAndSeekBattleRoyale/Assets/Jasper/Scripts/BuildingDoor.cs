using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingDoor : MonoBehaviour {

	public GameObject roof;


	private void OnTriggerEnter(Collider other)
	{
		roof.GetComponent<Renderer>().enabled = false;
	}
	private void OnTriggerExit(Collider other)
	{
		roof.GetComponent<Renderer>().enabled = true;
	}
}
