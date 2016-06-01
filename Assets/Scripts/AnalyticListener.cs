using UnityEngine;
using System.Collections;
using UnityEngine.Cloud.Analytics;
// Reference the Collections Generic namespace
using System.Collections.Generic;

public class AnalyticListener : MonoBehaviour {

	public GameController gameControll;

	void Awake()
	{
		Debug.Log("log");
		gameControll = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		UnityAnalytics.CustomEvent("gameOver", new Dictionary<string, object>
		                           {
			{ "score", gameControll.score},
			//{ "coins", totalCoins }
		});
		
		int coinsToAdd = PlayerPrefs.GetInt("CoinsCollected") + ObstacleCheck.coinsCollected;
		PlayerPrefs.SetInt("CoinsCollected", coinsToAdd);
	}

	public void Onclick() {

	}
}
