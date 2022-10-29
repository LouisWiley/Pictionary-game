using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Characteristics:
// after 30 seconds or until word is guessed correctly
// delete the lines in the scene and remake and
// generate a new word
public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeRemaining = 30;
    public GameObject deleteLine;

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            Debug.Log(timeRemaining);
        }
        else
        {
            Debug.Log("Times Up");

            foreach (GameObject line in GameObject.FindGameObjectsWithTag("Line"))
            {
                Destroy(line);
            }

            timeRemaining = 30; // refresh the timer
        }

    }
}
