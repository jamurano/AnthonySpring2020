using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] private State startingState;
    
    private State state;
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }
    
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index)) 
            { 
                state = nextStates[index]; 
            } 
        }
        textComponent.text = state.GetStateStory();
   }
}
