using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
	public bool canMove;
	public float moveSpeed;

    void Update()
    {
		if (canMove)
		{
			transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
		}
    }
}
