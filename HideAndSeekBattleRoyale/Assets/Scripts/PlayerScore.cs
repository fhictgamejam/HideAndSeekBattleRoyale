using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
	public int hitOppReward = 50;
	public int getHitLoss = 20;
	private int score;
	private float timer;
	int timeDif;
	int timeSec;
	// Use this for initialization
	void Start()
	{
		score = 0;
	}

	// Update is called once per frame
	void Update()
	{
		ScoreTime();

	}
	private void ScoreTime()
	{
		timer += Time.deltaTime;
		timeDif = (int)timer % 60;
		timeSec = (int)timer % 60;
		if (timeDif >= 2)
		{
			score++;
			timeDif = 0;
		}
	}
	public void HitOpponent()
	{
		score += hitOppReward;
	}
	public void GetHit()
	{
		score -= getHitLoss;
		if (score < 0)
		{
			score = 0;
		}
	}
}
