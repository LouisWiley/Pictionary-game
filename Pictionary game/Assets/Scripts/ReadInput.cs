using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
  
    private string guessWord;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ReadStringInput(string s)
    {
        guessWord = s;
        Debug.Log(guessWord);
        Debug.Log(GenerateWord.answer.GetWord());
        Debug.Log(GenerateWord.answer.IsCorrectGuess(s));
    }
}
