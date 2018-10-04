using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontFlip : MonoBehaviour
{

	public float timer = 0f;
	public float timerIncrease = 0f;
	public float rotationSpeed = 0f;

	private Vector3 flipRotation;
	// Use this for initialization
	void Start ()
	{
		timer = 0f;

		flipRotation = transform.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			timer += timerIncrease;
		
			Debug.Log("start flip");
		}
		
		if (timer > 0)
		{
			Debug.Log(transform.eulerAngles);
			flipRotation += new Vector3(rotationSpeed, 0f, 0f);
			transform.eulerAngles = flipRotation;
			timer -= 1 * Time.deltaTime;
			Debug.Log("Trying to flip");
		}
		
	}
}
