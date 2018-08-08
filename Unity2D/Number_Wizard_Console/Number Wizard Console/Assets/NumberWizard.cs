using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization
    void Start ()
    {
        StartGame();
	}
        
    void StartGame ()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Hey there! Welcome to Number Wizard!");
        Debug.Log("Let's have some fun. I'm gonna read your thoughts...");
        Debug.Log("Pick a number between " + max);
        Debug.Log("and " + min);
        Debug.Log("Got it? Now just tell me if your number is higher or lower than: " + guess);
        Debug.Log("Higher? Push UP. Lower? Just push DOWN. I guessed it and you're amazed? Push ENTER ;)");
        max = max + 1;
    }

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {           
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I GOT IT!");
            StartGame();
        }
    }   
   
    void NextGuess ()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher ir lower than..." + guess);

    }
}
