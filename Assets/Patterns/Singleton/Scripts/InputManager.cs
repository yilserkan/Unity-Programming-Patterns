using UnityEngine;
using UnityEngine.SceneManagement;

namespace ProgrammingPatterns.Patterns.Singleton.Scripts
{
    public class InputManager : Singleton<InputManager>
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
