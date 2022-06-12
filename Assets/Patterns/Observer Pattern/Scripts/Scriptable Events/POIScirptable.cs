using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POIScirptable : MonoBehaviour
{
    [SerializeField] private GameEvent OnPointOfInterestEntered;

    private void OnTriggerEnter(Collider other)
    {
        OnPointOfInterestEntered.Raise();
    }
}
