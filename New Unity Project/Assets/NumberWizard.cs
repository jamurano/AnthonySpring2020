using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int max;
    private int min;
    private int guess;
    
    void Start()
    {
        StartGame();
    }


    void StartGame()
    {

        max = 1000;
        min = 1;
        guess = 500;
        
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number...");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push up = higher, Push down = lower, Push enter = correct");
        max = max + 1;
    }
    void Update()
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
            Debug.Log("I am a genius!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number higher or lower than " + guess + "?");
    }
} 
