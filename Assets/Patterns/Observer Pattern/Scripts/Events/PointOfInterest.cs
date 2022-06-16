using System;
using UnityEngine;

namespace ProgrammingPatterns.Patterns.Observer_Pattern.Scripts.Events
{
    public class PointOfInterest : MonoBehaviour
    {
        public static event Action<string> OnPointOfInterestEntered;
    
        [SerializeField]
        private string _poiName;

        private void OnTriggerEnter(Collider other)
        {
            OnPointOfInterestEntered?.Invoke(_poiName);
        }
    }
}
