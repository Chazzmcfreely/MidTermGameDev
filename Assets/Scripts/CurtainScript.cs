using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainScript : MonoBehaviour
{

	private bool isRising = false;

	// Use this for initialization
	void Start ()
	{
		
	}

	public void Rise()
	{
		isRising = true;
		//Debug.Log("FUCK ME DADDY");
	}

	// Update is called once per frame
	void Update () {
		if (isRising)
		{
			transform.Translate(0f,0.05f,0f);
			//Debug.Log("Harder please");
		}
		
	}
}
