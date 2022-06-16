using UnityEngine;

namespace ProgrammingPatterns.Patterns.Observer_Pattern.Scripts.Scriptable_Events
{
    public class POIScirptable : MonoBehaviour
    {
        [SerializeField] private GameEvent OnPointOfInterestEntered;

        private void OnTriggerEnter(Collider other)
        {
            OnPointOfInterestEntered.Raise();
        }
    }
}
