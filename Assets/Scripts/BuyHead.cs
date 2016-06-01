using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuyHead : MonoBehaviour {

	int plays;
	public GameObject ericB;
	public GameObject kanyeB;
	public GameObject cheeseHeadB;
	public GameObject cloneB;
	public GameObject fezB;
	public GameObject glassesB;
	public GameObject linkB;
	public GameObject scouterB;
	public GameObject joeyB;
	public GameObject zackB;
	public GameObject[] buttons;
	private int currentCoins;
	string headText;

	// Use this for initialization
	void Awake () {
		Debug.Log(PlayerPrefs.GetInt("plays"));
		if(PlayerPrefs.GetInt("plays") == 0)
		{			
			PlayerPrefs.SetInt("CoinsCollected", 0);
			PlayerPrefs.SetString("HeadBought" + ericB, "0");	
			PlayerPrefs.SetString("HeadBought" + kanyeB, "0");	
			PlayerPrefs.SetString("HeadBought" + cheeseHeadB, "0");	
			PlayerPrefs.SetString("HeadBought" + cloneB, "0");	
			PlayerPrefs.SetString("HeadBought" + fezB, "0");	
			PlayerPrefs.SetString("HeadBought" + glassesB, "0");	
			PlayerPrefs.SetString("HeadBought" + scouterB, "0");	
			PlayerPrefs.SetString("HeadBought" + linkB, "0");	
			PlayerPrefs.SetString("HeadBought" + zackB, "0");	
			plays++;			
			PlayerPrefs.SetInt("plays", plays);
		}
		currentCoins = PlayerPrefs.GetInt("CoinsCollected");
		//ericB.GetComponent<Button>().interactable = false;
		//PlayerPrefs.SetString("HeadBought", "1");
		Debug.Log(PlayerPrefs.GetString("HeadBought" + scouterB));
		Debug.Log(PlayerPrefs.GetString("HeadBought" + kanyeB));
		Debug.Log(PlayerPrefs.GetInt("CoinsCollected"));
		UpdateShop();
	}
	
	// Update is called once per frame
	void Update()
	{
	}

	public void UpdateShop()
	{		

		if(currentCoins < 9000 && PlayerPrefs.GetString("HeadBought" + scouterB) == "0")
		{			
			scouterB.GetComponent<Button>().interactable = false;

		}
		else
		{
			scouterB.GetComponent<Button>().interactable = true;
		}
		if( currentCoins < 200 && PlayerPrefs.GetString("HeadBought" + kanyeB) == "0")
		{			
			kanyeB.GetComponent<Button>().interactable = false;
		}
		else
		{
			kanyeB.GetComponent<Button>().interactable = true;
		}
		if( currentCoins < 50 && PlayerPrefs.GetString("HeadBought" + ericB) == "0")
		{			
			ericB.GetComponent<Button>().interactable = false;
		}
		else
		{
			ericB.GetComponent<Button>().interactable = true;
		}
		if( currentCoins < 100 && PlayerPrefs.GetString("HeadBought" + cheeseHeadB) == "0")
		{			
			cheeseHeadB.GetComponent<Button>().interactable = false;
		}
		else
		{
			cheeseHeadB.GetComponent<Button>().interactable = true;
		}
		if( currentCoins < 300 && PlayerPrefs.GetString("HeadBought" + cloneB) == "0")
		{			
			cloneB.GetComponent<Button>().interactable = false;
		}
		else
		{
			cloneB.GetComponent<Button>().interactable = true;
		}
		if( currentCoins < 100 && PlayerPrefs.GetString("HeadBought" + fezB) == "0")
		{			
			fezB.GetComponent<Button>().interactable = false;
		}
		else
		{
			fezB.GetComponent<Button>().interactable = true;
		}
		if( currentCoins < 150 && PlayerPrefs.GetString("HeadBought" + glassesB) == "0")
		{			
			glassesB.GetComponent<Button>().interactable = false;
		}
		else
		{
			glassesB.GetComponent<Button>().interactable = true;
		}
		if( currentCoins < 300 && PlayerPrefs.GetString("HeadBought" + linkB) == "0")
		{			
			linkB.GetComponent<Button>().interactable = false;
		}
		else
		{
			linkB.GetComponent<Button>().interactable = true;
		}
		if( currentCoins < 50 && PlayerPrefs.GetString("HeadBought" + zackB) == "0")
		{			
			zackB.GetComponent<Button>().interactable = false;
		}
		else
		{
			zackB.GetComponent<Button>().interactable = true;
		}


		if(PlayerPrefs.GetString("HeadBought" + scouterB) == "1")
		{
			GameObject cost = scouterB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
		}
		if(PlayerPrefs.GetString("HeadBought" + cheeseHeadB) == "1")
		{
			GameObject cost = cheeseHeadB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
		}
		if(PlayerPrefs.GetString("HeadBought" + ericB) == "1")
		{
			GameObject cost = ericB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
		}
		if(PlayerPrefs.GetString("HeadBought" + zackB) == "1")
		{
			GameObject cost = zackB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
		}
		if(PlayerPrefs.GetString("HeadBought" + kanyeB) == "1")
		{
			GameObject cost = kanyeB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
		}
		if(PlayerPrefs.GetString("HeadBought" + fezB) == "1")
		{
			GameObject cost = fezB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
		}
		if(PlayerPrefs.GetString("HeadBought" + cloneB) == "1")
		{
			GameObject cost = cloneB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
		}
		if(PlayerPrefs.GetString("HeadBought" + glassesB) == "1")
		{
			GameObject cost = glassesB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
		}
		if(PlayerPrefs.GetString("HeadBought" + linkB) == "1")
		{
			GameObject cost = linkB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
		}

	}

	public void BuyItem(GameObject head)
	{
		headText = head.GetComponentInChildren<Text>().text;
		
		if(headText == "HAT-2010" && PlayerPrefs.GetString("HeadBought" + kanyeB) == "0")
		{
			currentCoins -= 200;
			Debug.Log(currentCoins);
			PlayerPrefs.SetInt("CoinsCollected", currentCoins);
			PlayerPrefs.SetString("HeadBought" + kanyeB, "1");			
			Debug.Log(PlayerPrefs.GetString("HeadBought" + kanyeB));
			GameObject cost = kanyeB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
			UpdateShop();
		}
		if(headText == "eric" && PlayerPrefs.GetString("HeadBought" + ericB) == "0")
		{
			currentCoins -= 50;
			Debug.Log(currentCoins);
			PlayerPrefs.SetInt("CoinsCollected", currentCoins);
			PlayerPrefs.SetString("HeadBought" + ericB, "1");			
			Debug.Log(PlayerPrefs.GetString("HeadBought" + ericB));
			GameObject cost = ericB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
			UpdateShop();
		}
		if(headText == "HAT-Scouter" && PlayerPrefs.GetString("HeadBought" + scouterB) == "0")
		{
			currentCoins -= 9000;
			Debug.Log(currentCoins);
			PlayerPrefs.SetInt("CoinsCollected", currentCoins);
			PlayerPrefs.SetString("HeadBought" + scouterB, "1");			
			Debug.Log(PlayerPrefs.GetString("HeadBought" + scouterB));
			GameObject cost = scouterB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
			UpdateShop();
		}
		if(headText == "HAT-Cheeshead" && PlayerPrefs.GetString("HeadBought" + cheeseHeadB) == "0")
		{
			currentCoins -= 100;
			Debug.Log(currentCoins);
			PlayerPrefs.SetInt("CoinsCollected", currentCoins);
			PlayerPrefs.SetString("HeadBought" + cheeseHeadB, "1");			
			Debug.Log(PlayerPrefs.GetString("HeadBought" + cheeseHeadB));
			GameObject cost = cheeseHeadB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
			UpdateShop();
		}
		if(headText == "HAT-CloneTrooper" && PlayerPrefs.GetString("HeadBought" + cloneB) == "0")
		{
			currentCoins -= 300;
			Debug.Log(currentCoins);
			PlayerPrefs.SetInt("CoinsCollected", currentCoins);
			PlayerPrefs.SetString("HeadBought" + cloneB, "1");			
			Debug.Log(PlayerPrefs.GetString("HeadBought" + cloneB));
			GameObject cost = cloneB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
			UpdateShop();
		}
		if(headText == "HAT-fez" && PlayerPrefs.GetString("HeadBought" + fezB) == "0")
		{
			currentCoins -= 100;
			Debug.Log(currentCoins);
			PlayerPrefs.SetInt("CoinsCollected", currentCoins);
			PlayerPrefs.SetString("HeadBought" + fezB, "1");			
			Debug.Log(PlayerPrefs.GetString("HeadBought" + fezB));
			GameObject cost = fezB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
			UpdateShop();
		}
		if(headText == "HAT-Glasses" && PlayerPrefs.GetString("HeadBought" + glassesB) == "0")
		{
			//currentCoins -= 150;
			Debug.Log(currentCoins);
			PlayerPrefs.SetInt("CoinsCollected", currentCoins);
			PlayerPrefs.SetString("HeadBought" + glassesB, "1");			
			Debug.Log(PlayerPrefs.GetString("HeadBought" + glassesB));
			GameObject cost = glassesB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
			UpdateShop();
		}
		if(headText == "HAT-Link" && PlayerPrefs.GetString("HeadBought" + linkB) == "0")
		{
			currentCoins -= 300;
			Debug.Log(currentCoins);
			PlayerPrefs.SetInt("CoinsCollected", currentCoins);
			PlayerPrefs.SetString("HeadBought" + linkB, "1");			
			Debug.Log(PlayerPrefs.GetString("HeadBought" + linkB));
			GameObject cost = linkB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
			UpdateShop();
		}
		if(headText == "zack" && PlayerPrefs.GetString("HeadBought" + zackB) == "0")
		{
			currentCoins -= 50;
			Debug.Log(currentCoins);
			PlayerPrefs.SetInt("CoinsCollected", currentCoins);
			PlayerPrefs.SetString("HeadBought" + zackB, "1");			
			Debug.Log(PlayerPrefs.GetString("HeadBought" + zackB));
			GameObject cost = zackB.transform.FindChild("Cost").gameObject;
			cost.SetActive(false);
			UpdateShop();
		}
		//if(headText)
	}

	public void AddCoins()
	{
		currentCoins += 1000;
		PlayerPrefs.SetInt("CoinsCollected", currentCoins);
		UpdateShop();

	}
}
