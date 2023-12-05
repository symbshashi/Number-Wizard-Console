using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        
        Startgame();
       
    }
    void Startgame()
    {
        Debug.Log("welcome to the Number Wizaed game");
        Debug.Log("Pick up a number and don't tell me  what it is");
        Debug.Log("The highest number you can pick is : " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Press up = Higher , Press down = Lower, Press Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            min = guess;
            Nextguess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           
            max = guess;
            Nextguess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius!");
            Startgame();
        }
    }
    void Nextguess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    }
}
