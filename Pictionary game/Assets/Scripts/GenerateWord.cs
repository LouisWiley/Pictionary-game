using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWord : MonoBehaviour
{
    // Start is called before the first frame update
    static private string[] wordBank = { "Cat", "Dog", "Mouse", "Horse", "House", "Heart", "Fish", "whisk", "spring", "cowboy" };
    static private int min = 0;
    static private int max = wordBank.Length - 1; //returns 10 - 1 = 9
    static private int randomIndex;
    static private string wordToGuess;

    void Start()
    {
        Debug.Log("max: " + max);
        randomIndex = Random.Range(min, max);

        Debug.Log("The Word Is: " + wordBank[randomIndex]);

        wordToGuess = wordBank[randomIndex];
        Debug.Log(wordToGuess);

    }

    public bool IsCorrectGuess(string guess)
    {
        if (guess == wordToGuess)
        {
            return true;
        }

        return false;
    }
    public string GetGuess()
    {
        return wordToGuess;
    }


    



}
