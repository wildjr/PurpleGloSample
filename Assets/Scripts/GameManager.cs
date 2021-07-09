using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public GameObject player;
	public GameObject ai;

	public GameObject startButton;
	public GameObject goText;
	public GameObject win;
	public GameObject loss;

	public GameObject startPos;
	public GameObject endPos;

	private PlayerMovement playerMovement;
	private AIMovement aIMovement;

	private bool winnerDetermined = false;

	private float camStartPos;
	private float camEndPos;
	private float currentProgress;

	private void Start()
	{
		playerMovement = player.GetComponent<PlayerMovement>();
		aIMovement = ai.GetComponent<AIMovement>();

		playerMovement.canMove = false;
		aIMovement.canMove = false;

		startButton.SetActive(true);
		goText.SetActive(false);
		win.SetActive(false);
		loss.SetActive(false);

		//camStartPos = transform.position.x;
		//float camDif = camStartPos - startPos.transform.position.x;
		//camEndPos = endPos.transform.position.x - camDif;
	}

	void Update()
    {
		if(player.transform.position.x > endPos.transform.position.x)
		{
			playerMovement.canMove = false;
			if(!winnerDetermined)
			{
				win.SetActive(true);
				winnerDetermined = true;
			}
		}

		if (ai.transform.position.x > endPos.transform.position.x)
		{
			aIMovement.canMove = false;
			if (!winnerDetermined)
			{
				loss.SetActive(true);
				winnerDetermined = true;
			}
		}

		//currentProgress = (player.transform.position.x - startPos.transform.position.x) / (endPos.transform.position.x - startPos.transform.position.x);
		//transform.position = new Vector3((camEndPos - camStartPos) * currentProgress + camStartPos, transform.position.y, transform.position.z);
	}

	public void StartGame()
	{
		playerMovement.canMove = true;
		aIMovement.canMove = true;

		startButton.SetActive(false);
		goText.SetActive(true);

		StartCoroutine("HideGoText");
	}

	public void RestartGame()
	{
		SceneManager.LoadScene(0);
	}

	IEnumerator HideGoText()
	{
		yield return new WaitForSeconds(5);
		goText.SetActive(false);
	}
}
