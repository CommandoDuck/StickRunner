using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeadChange : MonoBehaviour {

	Button head;
	string headText;
	//public Image[] circles;	
	public BuyHead buyHead;

	// Use this for initialization
	void Start () 
	{
		buyHead = GameObject.Find("Panel").GetComponent<BuyHead>();
		buyHead.buttons = GameObject.FindGameObjectsWithTag("head");
		head = gameObject.GetComponent<Button>();
		setHead();
	}

	// Update is called once per frame
	void OnGUI() 
	{
		head.onClick.AddListener(setHead);
	}



	void setHead() 
	{
		headText = head.GetComponentInChildren<Text>().text;
		GameController.controll.setHead(headText);
		PlayerPrefs.SetString("head",headText);
		GameObject currentHead = GameObject.Find(headText);
		Transform circle = currentHead.transform.FindChild("Circle");
		for(int i = 0; i < buyHead.buttons.Length; i++)
		{
			buyHead.buttons[i].transform.FindChild("Circle").GetComponent<Image>().enabled = false;
		}
		circle.GetComponent<Image>().enabled = true;
	}
}
