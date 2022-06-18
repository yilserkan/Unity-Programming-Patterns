using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace ProgrammingPatterns
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private BallLifeTime lifeTime;
        
        private bool hasContacted = false;
        
        private IObjectPool<Ball> _pool;

        public void SetPool(IObjectPool<Ball> objectPool) => _pool = objectPool;

        private float timeLivedAfterContact;

        private void OnCollisionEnter(Collision collision) => hasContacted = true;
        private void OnDisable() => hasContacted = false;
        
        private void Update()
        {
            if(!hasContacted) { return; }

            timeLivedAfterContact += Time.deltaTime;

            if (timeLivedAfterContact > lifeTime.ballLifeTimeAfterCollision)
            {
                _pool.Release(this);
            }
        }

        public void ResetTimer()
        {
            timeLivedAfterContact = 0;
        }
    }
}
