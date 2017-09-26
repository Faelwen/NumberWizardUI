using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

	// Use this for initialization
	public Text guessText;
	int max;
	int min;
	int guess;


	void Start ()
	{
		StartGame ();
	}

	void StartGame ()
	{
		max = 1000;
		min = 1;
		NextGuess ();
		guessText.text = guess.ToString ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			GuessHigher ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GuessLower ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			GuessCorrect ();
		}
	}

	public void GuessHigher ()
	{
		min = guess;
		NextGuess ();
	}

	public void GuessLower ()
	{
		max = guess;
		NextGuess ();
	}

	public void GuessCorrect ()
	{
		StartGame ();
	}

	void NextGuess ()
	{
		guess = Random.Range (min, max + 1);
		guessText.text = guess.ToString ();
	}
}
