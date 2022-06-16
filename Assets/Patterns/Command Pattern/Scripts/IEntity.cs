using UnityEngine;

namespace ProgrammingPatterns.Patterns.Command_Pattern.Scripts
{
    public interface IEntity 
    {
        Transform transform { get; }
        void MoveFromTo(Vector3 startPosition, Vector3 endPosition);
    }
}
