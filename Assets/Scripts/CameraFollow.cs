using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	public Transform target;

	public float smoothSpeed = 0.125f;
	public Vector3 offSet;
	private Vector3 velocity = new Vector3(0f,0f,0f);

	void LateUpdate()
	{

		Vector3 desiredPosition = target.position + offSet;
		Debug.Log(desiredPosition);
		Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
		Debug.Log(smoothedPosition);
		transform.position = smoothedPosition;

		//transform.LookAt(target);
	}
}
