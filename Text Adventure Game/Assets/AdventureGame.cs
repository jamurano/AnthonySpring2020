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
        
    }
}
