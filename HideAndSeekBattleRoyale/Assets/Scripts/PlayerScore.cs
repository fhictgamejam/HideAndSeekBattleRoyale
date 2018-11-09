using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
	public int hitOpponentReward = 50;
	public int getHitLoss = 20;
	private int score;
	private float timer;
	int timeDif;

	public GameObject parent;
	public Text scorePrefab;

	float downPlacement = 0;


	private List<Text> scores = new List<Text>();
	private List<int> plScores = new List<int>();
	private List<int> oldPlScores = new List<int>();
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
	public void AddPlayerScore(List<int> gScores)
	{
		plScores.Clear();
		oldPlScores = gScores;
		if (gScores == null)
		{
			gScores = new List<int>();
		}
		else
		{
			plScores = gScores;
		}
		gScores.Add(this.score);
		InstantiateScoreFields();
	}
	private void InstantiateScoreFields()
	{
		plScores.Sort((a, b) => -1 * a.CompareTo(b));
		foreach (Text sText in scores)
		{
			Destroy(sText.gameObject);
		}
		scores.Clear();
		foreach (var s in plScores)
		{
			Text plScore = Instantiate(scorePrefab, parent.transform);
			plScore.transform.Translate(new Vector3(0, -downPlacement));
			downPlacement += plScore.rectTransform.rect.height;
			plScore.text = s.ToString();
			scores.Add(plScore);
		}
		downPlacement = 0;
	}

	private void ScoreTime()
	{
		timer += Time.deltaTime;
		timeDif = (int)timer % 60;
		if (timeDif >= 2)
		{
			timer = 0;
			score += 2;
		}
		AddPlayerScore(oldPlScores);
	}
	public void HitOpponent()
	{
		score += hitOpponentReward;
		AddPlayerScore(oldPlScores);
	}
	public void GetHit()
	{
		score -= getHitLoss;
		if (score < 0)
		{
			score = 0;
		}
		AddPlayerScore(oldPlScores);
	}

	public int GetScore()
	{
		return this.score;
	}
}
