using System;
using UnityEngine;

namespace ProgrammingPatterns.Interface.Scripts
{
    public class PlayerInterface : MonoBehaviour
    {
        [SerializeField] private int speed = 1;
        
        private void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= speed * Time.deltaTime * Vector3.right;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += speed * Time.deltaTime * Vector3.right;
            }
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                TryInteracting();
            }
        }

        private void TryInteracting()
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position ,transform.forward, out hit, 100))
            {
                IInteractable interactable = hit.transform.GetComponent<IInteractable>();
                if (interactable != null)
                {
                    interactable.Interact();
                }
            }
            
        }

        // private void OnTriggerStay(Collider other)
        // {
        //     IInteractable interactable = other.GetComponent<IInteractable>();
        //     if (interactable != null)
        //     {
        //         interactable.Interact();
        //     }
        // }
    }
}
