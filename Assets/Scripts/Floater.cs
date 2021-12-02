//https://www.youtube.com/watch?v=eL_zHQEju8s&t=510s

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater: MonoBehaviour
{

	public Rigidbody rigidbody;
	public float depthBeforeSubmerged = 0.5f;
	public float displacementAmount = 3.0f;

	private void FixedUpdate()
	{

		if (transform.position.y < 0.0f)
		{
			float displacementMultiplier = Mathf.Clamp01(-transform.position.y / depthBeforeSubmerged) * displacementAmount;
			rigidbody.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0.0f), ForceMode.Acceleration);
		}
	}
}