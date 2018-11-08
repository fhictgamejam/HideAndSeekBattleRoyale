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
		weaponHolder.transform.rotation = new Quaternion(0, WeaponRotation(), 0, 0);
		transform.Translate(move);
	}
	private float WeaponRotation()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			return 180;
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			return 90;
		}
		else if (Input.GetKeyDown(KeyCode.D))
		{
			return 0;
		}
		else if (Input.GetKeyDown(KeyCode.W))
		{
			return 270;
		}
		else
		{
			return weaponHolder.transform.rotation.y;
		}
	}
}