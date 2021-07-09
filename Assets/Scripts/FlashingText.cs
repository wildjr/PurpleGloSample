using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashingText : MonoBehaviour
{
	private Text text;

	private void Start()
	{
		text = GetComponent<Text>();
		InvokeRepeating("Flash", 0.5f, 0.5f);
	}

	void Flash()
	{
		if (text.color.a == 1)
			text.color = new Vector4(text.color.r, text.color.g, text.color.b, 0);
		else
			text.color = new Vector4(text.color.r, text.color.g, text.color.b, 1);

	}
}
