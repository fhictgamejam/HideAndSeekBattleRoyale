using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

	public GameObject player;
	public float attackTime = 0.1f;
	public float attackSpeed = 0.1f;
	private float goinAttackDuration;
	private float goingAttackTime = 0;
	private bool attack = false;
	private bool retreiveAttack = false;
	private Quaternion beginpoint;

	private void Start()
	{
		this.GetComponent<Renderer>().enabled = false;
	}
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !attack && !retreiveAttack)
		{
			this.GetComponent<Renderer>().enabled = true;
			beginpoint = this.transform.rotation;
			attack = true;
			retreiveAttack = true;
		}
		if (attack || retreiveAttack)
		{
			DoAttack();
		}
	}
	private void OnTriggerEnter(Collider other)
	{

		if (other.tag == player.tag)
		{
			Destroy(other.gameObject);
		}
	}
	private void DoAttack()
	{
		if (goingAttackTime < attackTime && attack)
		{
			this.transform.Rotate(new Vector3(0, -attackSpeed));
			goingAttackTime += Time.deltaTime;
		}
		else
		{
			attack = false;
			if (goingAttackTime > 0)
			{
				goingAttackTime -= Time.deltaTime;
				this.transform.Rotate(new Vector3(0, attackSpeed));
			}
			else
			{
				this.transform.rotation = beginpoint;
				this.GetComponent<Renderer>().enabled = false;
				goingAttackTime = 0;
				retreiveAttack = false;
			}
		}
	}
}
