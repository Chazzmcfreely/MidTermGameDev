using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinBouncer : MonoBehaviour {
	
	//Kevin Ray Lent me part of this script <3


	private float ran;

	private Vector3 rotation;
	//How High it bounces up and down
	public float heightScale = 2.0F;
	//How Frequently it bounces
	public float xScale = 1.0F;
	//The height at which it bounces
	public float heightMod = 0f;

	void Update ()
	{
		float ran = Random.Range(0, 10);
		rotation = new Vector3(0, ran, 0);
		float height = heightScale * Mathf.PerlinNoise (Time.time * xScale, Time.time * xScale) + heightMod;
		Vector3 pos = transform.position;
		
		pos.y = height;
		transform.position = pos;
		transform.localEulerAngles += rotation;

	}
}
