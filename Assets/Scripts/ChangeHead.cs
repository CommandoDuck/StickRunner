using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeHead : MonoBehaviour {

	 Sprite head;

	public string headName;
	public GameController gameController;
	//SpriteRenderer rend;

   void	Awake()
	{
		gameController = GameObject.Find("GameController").GetComponent<GameController>();
		headName = gameController.getHead();;
		head = Resources.Load<Sprite>(headName) as Sprite;
		Debug.Log(head.name);
		GetComponent<SpriteRenderer>().sprite = head;

	}

	public void ChangeHeadSprite()
	{

	}


   
}
