using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public bool canMove;
	public float moveSpeed;

	private Rigidbody rb;
	private AudioSource audioSource;
	
	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		audioSource = GetComponent<AudioSource>();
	}

	void Update()
	{
		if (canMove && !audioSource.isPlaying)
			audioSource.Play();

		if (canMove && Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(Vector3.right * moveSpeed);
		}
		
		audioSource.volume = rb.velocity.x;
	}
}
