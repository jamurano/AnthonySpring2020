using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int max = 1000;
    private int min = 1;
    
    void Start()
    {
        
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number...");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me your number is higher or lower than 500");
        Debug.Log("Push up = higher, Push down = lower, Push enter = correct");
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow was pressed");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow was pressed");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter button was pressed");
        }
    }
}
