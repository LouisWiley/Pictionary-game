using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
  
    private string guessWord;
    // Start is called before the first frame update
    public GameObject userFeedback;
    public Sprite correctFeedback;
    public Sprite wrongFeedback;


    public void ReadStringInput(string s)
    {
        
       // text = GetComponent<UnityEngine.UI.Text>();
        Debug.Log(s);
       
        Debug.Log(GenerateWord.answer.GetWord());
        Debug.Log(GenerateWord.answer.IsCorrectGuess(s));

        

        if (GenerateWord.answer.IsCorrectGuess(s))
        {
            Debug.Log("Correct");
            userFeedback.GetComponent<Image>().sprite = correctFeedback;
            
        }
        else
        {
            Debug.Log("Wrong");
            userFeedback.GetComponent<Image>().sprite = wrongFeedback;
        }
    }
}
