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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else(Input.GetKeyDown(KeyCode.Alpha3))

        {
            state = nextStates[2];
        }
        textComponent.text = state.GetStateStory();
    }
}
