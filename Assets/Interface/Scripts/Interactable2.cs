using UnityEngine;

namespace ProgrammingPatterns.Interface.Scripts
{
    public class Interactable2 : MonoBehaviour, IInteractable
    {
    
        public void Interact()
        {
            Debug.Log("Interacted with Interactable 2");
        }
    }
}
