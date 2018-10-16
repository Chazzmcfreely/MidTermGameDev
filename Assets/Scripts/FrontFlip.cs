using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontFlip : MonoBehaviour
{

	public float timer = 0f;
	public float timerIncrease = 0f;
	public float rotationSpeed = 0f;

	public bool canFlip;
	
	private Vector3 flipRotation;
	// Use this for initialization
	void Start ()
	{
		timer = 0f;

		flipRotation = transform.localEulerAngles;
		canFlip = false;
	}

	public void enableFlip()
	{
		canFlip = true;
	}
	
	// Update is called once per frame
	void Update()
	{

		if (canFlip)
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				timer += timerIncrease;

				Debug.Log("start flip");
			}

			if (timer > 0)
			{
				Debug.Log(transform.eulerAngles);
				flipRotation += new Vector3(rotationSpeed, 0f, 0f) * Time.deltaTime;
				transform.localEulerAngles = flipRotation;
				timer -= 1 * Time.deltaTime;
				Debug.Log("Trying to flip");

			}
			else if (timer < 0)
			{
				transform.localEulerAngles = Vector3.zero;

			}

		}
	}
}
