using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManger : MonoBehaviour {
	
	public Text CoinCounter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		CoinCounter.text = PlayerPrefs.GetInt("CoinsCollected").ToString();
	}
}
