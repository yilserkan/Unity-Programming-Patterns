using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPatterns
{
    public class BirdController
    {
        private IBird _bird;

        public BirdController(IBird bird)
        {
            _bird = bird;
        }
        
        public void Move(float input)
        {
            _bird.Position += input * Vector3.up;
            
            if (_bird.Position.y > _bird.MaxHeight)
            {
                _bird.Position = new Vector3(_bird.Position.x, _bird.MaxHeight, _bird.Position.z);
            }
            else if (_bird.Position.y < _bird.MinHeight)
            {
                _bird.Position = new Vector3(_bird.Position.x, _bird.MinHeight, _bird.Position.z);
            }
        }
    }
}
