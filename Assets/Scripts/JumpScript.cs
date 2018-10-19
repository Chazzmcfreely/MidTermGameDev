using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{

	public int forceConst = 50;

	private bool Jump;
	private bool onGround = true;
	private Rigidbody selfRigidbody;

	void Start()
	{
		selfRigidbody = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		if (Jump)
		{
			Jump = false;
			selfRigidbody.AddForce(0, forceConst, 0, ForceMode.Impulse);
		}
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && onGround){
			Jump = true;
		}
		
		Ray myRay = new Ray(transform.position, Vector3.down);
		
		// STEP 2: define the distance of the raycast
		float myRaycastMaxDist = 0.6f; // a bit longer than half of the height
		
		// STEP 3: (optional) visualize the raycast
		Debug.DrawRay( myRay.origin, myRay.direction * myRaycastMaxDist, Color.yellow );
		
		// STEP 4: let's finally cast some raycasts!!!
		// raycasts return TRUE or FALSE, so ideal for if() statements
		if (Physics.Raycast(myRay, myRaycastMaxDist))
		{
			onGround = true;
			// if true (if the raycast hit a collider), then...
			Debug.Log("grounded is TRUE!");
			//transform.Rotate(0f, 5f, 0f); // debug: spin if on the ground?
		}
		else
		{
			onGround = false;
			// if false (if the raycast DID NOT hit the floor?), then...
			// ... do nothing?
		}
		
	}
}

/// code from here: https://answers.unity.com/questions/1207400/how-to-make-a-simple-jump-script-in-3d-c.html