using UnityEngine;

namespace ProgrammingPatterns.Patterns.Observer_Pattern.Scripts.Events
{
    public class SimpleMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 2;
        void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Time.deltaTime * speed * Vector3.left;
            }   
            else if (Input.GetKey(KeyCode.D))
            {
                transform.position += Time.deltaTime * speed * Vector3.right ;
            }
        }
    }
}
