using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestControls : MonoBehaviour
{
	public float speed;
	public GameObject weaponHolder;


	// Update is called once per frame
	void Update()
	{
		Vector3 move = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
		if (Input.GetKeyDown(KeyCode.A))
		{
			weaponHolder.transform.localRotation = Quaternion.Euler(0, 180, 0);
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			weaponHolder.transform.localRotation = Quaternion.Euler(0, 90, 0);
		}
		else if (Input.GetKeyDown(KeyCode.D))
		{
			weaponHolder.transform.localRotation = Quaternion.Euler(0, 0, 0);
		}
		else if (Input.GetKeyDown(KeyCode.W))
		{
			weaponHolder.transform.localRotation = Quaternion.Euler(0, 270, 0);
		}
		transform.Translate(move);
	}
}