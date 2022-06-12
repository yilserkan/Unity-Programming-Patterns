using System;
using UnityEngine;

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
