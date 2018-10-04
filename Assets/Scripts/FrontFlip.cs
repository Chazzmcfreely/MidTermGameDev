using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontFlip : MonoBehaviour
{

	private float timer = 0f;
	public float rotationSpeed = 0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			timer = 10f;
		
			Debug.Log("FLIP ME");
		}
		
		if (timer > 0)
		{
			transform.eulerAngles += new Vector3(rotationSpeed, 0f, 0f);
			timer -= 1 * Time.deltaTime;
		}
		
	}
}
