using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class HintScript : MonoBehaviour {

	private string[] mySentences = new string[10];
	public Text hintText;
	
	public int phaseNum;
	
	public Vector3 itemOne;
	public Vector3 itemTwo;
	public Vector3 itemThree;
	public Vector3 itemFour;
	public Vector3 itemFive;
	public Vector3 itemSix;
	public Vector3 itemSeven;
	public Vector3 itemEight;


	public float hintDistance;
	
	public GameObject firstTarget;
	public GameObject secondTarget;
	public GameObject thirdTarget;
	public GameObject fourthTarget;
	public GameObject fifthTarget;
	public GameObject sixthTarget;
	public GameObject seventhTarget;
	public GameObject eigthTarget;








	private CurtainScript CurtainScript;
	
	
	
	// Use this for initialization
	void Start ()
	{
		mySentences[0] = "This summer was the best summer of my life hands down," +
		                 "\n and this game is about a small yet important part of it";
		
		mySentences[1] = "I was lucky enough to be in a production of Disney's Newsies this summer," +
		                 "\n which is an incredibly fun and acrobatic musical, and it was decided early" +
		                 "\n on that I would be performing a front flip during the finale of act 1: Seize the Day";
		
		mySentences[2] = "Unfortunately, two weeks before opening night, I got injured during " +
		                 "\n a skateboarding accident, thus preventing me from doing a front flip";
		mySentences[3] = "Fast forward to the final show of the season, and I want to pull off" +
		                 "\n the front flip more than anything, but I haven't done one since my accident." +
						"\n everyone is here, and its make or break time, either I try to flip," +
						"\n or I live the rest of my life in regret.";

		mySentences[4] = "Press 'E' to raise curtain";
		mySentences[5] = "Follow the Choreography!";
		mySentences[6] = "Follow the Choreography!";
		mySentences[7] = "Follow the Choreography!";
		mySentences[8] = "Follow the Choreography!";
		mySentences[9] = "Press 'SPACE' to do a front flip";
		
		itemOne = firstTarget.transform.position;
		itemTwo = secondTarget.transform.position;
		itemThree = thirdTarget.transform.position;
		itemFour = fourthTarget.transform.position;
		itemFive = fifthTarget.transform.position;
		itemSix = sixthTarget.transform.position;
		itemSeven = seventhTarget.transform.position;
		itemEight = eigthTarget.transform.position;

		phaseNum = 0;
		hintDistance = 1f;
		CurtainScript = GameObject.FindObjectOfType<CurtainScript>();


	}

	public void checkPosition(Vector3 playerPos)
	{
			if (phaseNum == 0 && Vector3.Distance(playerPos, itemOne) < hintDistance)
			{
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
			if (phaseNum == 4 && Vector3.Distance(playerPos, itemFour) < hintDistance && Input.GetKeyDown(KeyCode.E))
			{
				phaseNum++;
				CurtainScript.Rise();
			}
			if (phaseNum == 5 && Vector3.Distance(playerPos, itemFive) < hintDistance)
			{
				phaseNum++;
			}
			if (phaseNum == 6 && Vector3.Distance(playerPos, itemSix) < hintDistance)
			{
				phaseNum++;
			}
			if (phaseNum == 7 && Vector3.Distance(playerPos, itemSeven) < hintDistance)
			{
				phaseNum++;
			}
			if (phaseNum == 8 && Vector3.Distance(playerPos, itemEight) < hintDistance)
			{
				phaseNum++;
			}

		
	}
	
	
	// Update is called once per frame
	void Update ()
	{
		hintText.text = mySentences[phaseNum];
		

		//Debug.Log(phaseNum.ToString());


	}
}