﻿using System.Collections;
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
		transform.Translate(move);
	}

	public void MoveVertical(float dis)
	{
		Vector3 move = new Vector3(0, 0, dis * speed * Time.deltaTime);

		transform.Translate(move);
	}
	public void RotateWeapon(float xval, float yval)
	{
		float _xval = xval;
		float _yval = yval;

		if (xval < 0)
		{
			_xval = xval * -1;
		}
		if (yval < 0)
		{
			_yval = yval * -1;
		}
		if (_xval > _yval)
		{
			if (xval < 0)
			{
				weaponHolder.transform.localRotation = Quaternion.Euler(0, 180, 0);
			}
			else
			{
				weaponHolder.transform.localRotation = Quaternion.Euler(0, 0, 0);
			}
		}
		else
		{
			if (yval < 0)
			{
				weaponHolder.transform.localRotation = Quaternion.Euler(0, 90, 0);
			}
			else
			{
				weaponHolder.transform.localRotation = Quaternion.Euler(0, 270, 0);
			}

		}
	}
}