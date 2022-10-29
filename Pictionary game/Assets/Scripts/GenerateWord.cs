using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GenerateWord : MonoBehaviour
{
    // Start is called before the first frame update
    static private string[] wordBank = { "Cat", "Dog", "Mouse", "Horse", "House", "Heart", "Fish", "whisk", "spring", "cowboy" };
    static private int min = 0;
    static private int max = wordBank.Length - 1; //returns 10 - 1 = 9
    static private int randomIndex;
    private string wordToGuess;
 public static GenerateWord answer;
    public Text drawThis;
    void Start()
    {
        string word;
        
        Debug.Log("max: " + max);
        randomIndex = Random.Range(min, max);

        Debug.Log("The Word Is: " + wordBank[randomIndex]);

        word = wordBank[randomIndex];
        answer = new GenerateWord(word);
        Debug.Log(answer.GetWord());
     //   drawThis.text = "Draw a: " + answer.GetWord();
    }

    public bool IsCorrectGuess(string guess)
    {
        if (guess.ToLower() == wordToGuess.ToLower()) //compare the whole word to the answer so input like CAT CaT and caT are valid inputs but cats isn't.
        {
            return true;
        }

        return false;
    }

    private void SetWord(string s)
    {
        this.wordToGuess = s;
    }
    public string GetWord()
    {
        Debug.Log(this.wordToGuess);
        return this.wordToGuess;
    }
    public GenerateWord(string s)
    {
        this.SetWord(s);
        Debug.Log("The Answer is :" + this.GetWord());
    }



    



}
