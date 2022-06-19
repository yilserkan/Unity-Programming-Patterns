using UnityEngine;

namespace ProgrammingPatterns.Patterns.Object_Pooling.Scripts
{
    [CreateAssetMenu(fileName = "New Ball Life Time", menuName = "ScriptableObjects/Ball")]
    public class BallLifeTime : ScriptableObject
    {
        public float ballLifeTimeAfterCollision;
    }
}
