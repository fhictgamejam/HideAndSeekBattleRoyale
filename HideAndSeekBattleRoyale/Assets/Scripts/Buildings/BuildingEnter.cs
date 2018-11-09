using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingEnter : MonoBehaviour {

	public GameObject[] roofs;

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			foreach (GameObject roof in roofs)
			{
				roof.GetComponent<Renderer>().enabled = false;
			}
		}
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			foreach (GameObject roof in roofs)
			{
				roof.GetComponent<Renderer>().enabled = true;
			}
		}
	}
}
