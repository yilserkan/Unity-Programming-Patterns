using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPatterns
{
    public class Bird : MonoBehaviour, IBird
    {
        private BirdController _birdController;
        
        [SerializeField] private float maxHeight = 3f;
        public float MaxHeight
        {
            get { return maxHeight; }
        }

        [SerializeField] private float minHeight = -3f;
        public float MinHeight
        {
            get { return minHeight; }
        }
        
        public Vector3 Position
        {
            get { return transform.position;}
            set { transform.position = value; }
        }

        private void Awake() => _birdController = new BirdController(this);

        private void Update()
        {
            float vertical = Input.GetAxis("Vertical");
            _birdController.Move(vertical);
        }
    }
}
