using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public bool canMove;
	public float moveSpeed;

	private Rigidbody rb;
	
	private void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
		if (canMove && Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(Vector3.right * moveSpeed);
		}
	}
}
