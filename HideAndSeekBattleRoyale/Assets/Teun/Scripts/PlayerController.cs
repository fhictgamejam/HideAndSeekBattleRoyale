using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Vector2 touchStart;

	void Update () {
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			switch(touch.phase)
			{
				case TouchPhase.Began:
					touchStart = touch.position;
					break;

			case TouchPhase.Moved:
			case TouchPhase.Stationary:
				Vector2 touchMovementVector = touch.position - touchStart;
				transform.Translate (touchMovementVector.x, touchMovementVector.y, 0);
				break;
			}
		}

	}
}
