using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
	public bool canMove;
	public float moveSpeed;

	private AudioSource audioSource;

	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	void Update()
    {
		if (canMove)
		{
			if (!audioSource.isPlaying)
				audioSource.Play();

			transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
		}
		else if (audioSource.isPlaying)
			audioSource.Stop();
    }
}
