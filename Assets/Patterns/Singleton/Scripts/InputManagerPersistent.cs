using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManagerPersistent : SingletonPersistent<InputManagerPersistent>
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Jump()
    {
        Debug.Log("Jumpping");
    }
}
