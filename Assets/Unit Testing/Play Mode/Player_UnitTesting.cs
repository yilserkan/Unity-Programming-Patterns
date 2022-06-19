using System;
using UnityEngine;

namespace ProgrammingPatterns
{
    [RequireComponent(typeof(Rigidbody))]
    public class Player_UnitTesting : MonoBehaviour
    {
        public IPlayerInputs _playerInputs;
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _rigidbody.useGravity = false;
        }

        private void Update()
        {
            float speed = 50f; 
            _rigidbody.AddForce(0,0,_playerInputs.Vertical * speed) ;
        }
    }
}
