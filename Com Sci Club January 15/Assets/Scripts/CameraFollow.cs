using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
	Transform camTransform;

	public Vector3 offset = new Vector3(0, 3.5f, -7);

	// How long the object should shake for.
	public float shakeDuration = 0f;

	// Amplitude of the shake. A larger value shakes the camera harder.
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1.0f;

	void Awake()
	{
		if (camTransform == null)
		{
			camTransform = FindObjectOfType<Camera>().transform;
		}
	}

	// Update is called once per frame (60fps) 
	void Update()
    {
		if (shakeDuration > 0)
		{
			camTransform.localPosition = playerTransform.position + offset + Random.insideUnitSphere * shakeAmount;

			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
		else
		{
			shakeDuration = 0f;
			camTransform.localPosition = playerTransform.position + offset;
		}
	}
}
