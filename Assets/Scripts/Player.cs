
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public float moveSpeed = 4.0f;
	public float rotationSpeed = 4.0f;
	private Vector3 playerPos;
	//private HintScript HintScript;
	
	// Use this for initialization
	void Start ()
	{
		//HintScript = GameObject.FindObjectOfType<HintScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(0f, 0f, moveSpeed);
		}
		
		if (Input.GetKey(KeyCode.A))
		{
			transform.eulerAngles += new Vector3(0f, -rotationSpeed, 0f);
		}
		
		if (Input.GetKey(KeyCode.D))
		{
			transform.eulerAngles += new Vector3(0f, rotationSpeed, 0f);
		}

		playerPos = transform.position;
		//HintScript.checkPosition(playerPos);
	}
}
