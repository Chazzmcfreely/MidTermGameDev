using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class HintScript : MonoBehaviour {

	private string[] mySentences = new string[6];
	public Text hintText;
	public int phaseNum;
	public Vector3 itemOne;
	public Vector3 itemTwo;
	public Vector3 itemThree;
	public Vector3 itemFour;
	public float hintDistance;
	public GameObject firstTarget;

	
	
	
	// Use this for initialization
	void Start ()
	{
		mySentences[0] = "This is it, your final show, and everything is riding" +
		                 "\n on this performance. I really want to do the front flip" +
		                 "\n but I haven't tried it since I was injured";
		mySentences[1] = "YOu can do this" +
		                 "\n I know you can!";
		mySentences[2] = "Hmm, this is a well that is shooting up water, but it isn't the wave." +
		                 "\nMaybe it is that thing to my right again?";
		mySentences[3] = "Damn, it really be like that sometimes." +
		                 "\nI guess I should check out that thing to my left, huh?";
		mySentences[4] = "Kanye? I should have known all along that he was the new wave!" +
		                 "\nI guess I should press SPACE to really feel the new wave.";
		mySentences[5] = "Thank you Kanye, very cool!";
		
		itemOne = new Vector3(-0.51f, 0.09f, -0.56f);
		itemTwo = new Vector3(-44.1f, 1.02f, 12.11f);
		itemThree = new Vector3(-65.5f, 5.6f, -24.8f);
		itemFour = new Vector3(-31.8f, -0.1f, -65.5f);
		phaseNum = 0;
		hintDistance = 1f;


	}

	public void checkPosition(Vector3 playerPos)
	{
			if (phaseNum == 0 && Vector3.Distance(playerPos, itemOne) < hintDistance)
			{
				Debug.Log("help");
				phaseNum++;
				Destroy(firstTarget);
			}

			if (phaseNum == 1 && Vector3.Distance(playerPos, itemTwo) < hintDistance)
			{
				phaseNum++;
			}

			if (phaseNum == 2 && Vector3.Distance(playerPos, itemThree) < hintDistance)
			{
				phaseNum++;
			}

			if (phaseNum == 3 && Vector3.Distance(playerPos, itemFour) < hintDistance)
			{
				phaseNum++;
			}
			if (phaseNum == 4 && Input.GetKeyDown(KeyCode.Space))
			{
			phaseNum = 5;
				
			}
	}
	
	
	// Update is called once per frame
	void Update ()
	{
		hintText.text = mySentences[phaseNum];
		

		//Debug.Log(phaseNum.ToString());


	}
}