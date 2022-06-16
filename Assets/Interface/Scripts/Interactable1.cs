using UnityEngine;

namespace ProgrammingPatterns.Interface.Scripts
{
    public class Interactable1 : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interacted with Interactable 1");
        }
    }
}
