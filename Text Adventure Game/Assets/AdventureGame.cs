using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;

    void Start()
    {
        textComponent.text = ("Festers. Everywhere. Armed mostly with gas-powered rock flingers. " +
                              "At least 10 of them guarding the hangar door. Typical." +
                              "Could try punching my way through. Or sneaking the long way to the emergency exit. " +
                              "What should I do?" +
                              "1. Take them head on - rush the guards." +
                              "2. Sneak my way to the emergency exit.");
    }
    
    void Update()
    {
        
    }
}
