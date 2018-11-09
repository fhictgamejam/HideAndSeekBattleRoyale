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
	}

	public void MoveHorizontal(float dis)
	{
		Vector3 move = new Vector3(dis * speed * Time.deltaTime, 0, 0);
		RotateWeapon(dis, true);
		transform.Translate(move);
	}

	public void MoveVertical(float dis)
	{
		Vector3 move = new Vector3(0, 0, dis * speed * Time.deltaTime);
		RotateWeapon(dis, false);
		transform.Translate(move);
	}
	private void RotateWeapon(float value, bool horizontal)
	{
		if (horizontal)
		{
			if (value > 0)
			{
				weaponHolder.transform.localRotation = Quaternion.Euler(0, 0, 0);
			}
			else
			{
				weaponHolder.transform.localRotation = Quaternion.Euler(0, 180, 0);
			}
		}
		else if(!horizontal)
		{
			if (value > 0)
			{
				weaponHolder.transform.localRotation = Quaternion.Euler(0, 270, 0);
			}
			else
			{
				weaponHolder.transform.localRotation = Quaternion.Euler(0, 90, 0);
			}
		}
	}
}