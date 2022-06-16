using UnityEngine;

namespace ProgrammingPatterns.Patterns.Singleton.Scripts
{
    public class Player : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                InputManagerPersistent.Instance.Jump();
            }
        
        }
    }
}
