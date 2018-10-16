using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{

	public int forceConst = 50;

	private bool canJump;
	private Rigidbody selfRigidbody;

	void Start()
	{
		selfRigidbody = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		if (canJump)
		{
			canJump = false;
			selfRigidbody.AddForce(0, forceConst, 0, ForceMode.Impulse);
		}
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space)){
			canJump = true;
		}
	}
}

/// code from here: https://answers.unity.com/questions/1207400/how-to-make-a-simple-jump-script-in-3d-c.html