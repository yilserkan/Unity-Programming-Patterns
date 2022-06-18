using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPatterns
{
    [CreateAssetMenu(fileName = "New Ball Life Time", menuName = "ScriptableObjects/Ball")]
    public class BallLifeTime : ScriptableObject
    {
        public float ballLifeTimeAfterCollision;
    }
}
