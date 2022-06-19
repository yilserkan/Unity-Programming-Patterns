using UnityEngine;
using UnityEngine.Pool;
using Random = UnityEngine.Random;


namespace ProgrammingPatterns.Patterns.Object_Pooling.Scripts
{
    public class BallSpawner : MonoBehaviour
   {
        [SerializeField] private Ball ballPrefab;
        [SerializeField] private Gradient colorGradiant;
        [SerializeField] [Range(0,1)] private float gradiantSpeed;
        [SerializeField] private Transform spawnPosition;
        [SerializeField] private float spawnPositionOffset;

        [SerializeField] private int ActiveCount;
        [SerializeField] private int InactiveCount;
        
        private float timeGradiant;
        
        
        private ObjectPool<Ball> _objectPool;

        // private void Awake() => _objectPool = new ObjectPool<MyBall>(CreateBall, BallActionOnGet, BallOnRelease, ActionOnDestroy, false, 100, 1000);
        private void Awake() => _objectPool = new ObjectPool<Ball>(CreateBall, BallActionOnGet, BallOnRelease);
        
        private void Update()
        {
            Ball ball = _objectPool.Get();
            ball.transform.position = ChooseRandomPosition();
            ActiveCount = _objectPool.CountActive;
            InactiveCount = _objectPool.CountInactive;
        }

        private Ball CreateBall()
        {
            Ball ball = Instantiate(ballPrefab, transform);
            ball.SetPool(_objectPool);
            return ball;
        }

        private void BallActionOnGet(Ball ball)
        {
            ball.gameObject.SetActive(true);

            timeGradiant += Time.deltaTime * gradiantSpeed;
            
            if (timeGradiant > 1)
            {
                timeGradiant = 0;
            }
            
            Color ballColor = colorGradiant.Evaluate(timeGradiant);
            ball.GetComponent<MeshRenderer>().material.color = ballColor;
        }
        
        private void BallOnRelease(Ball ball)
        {
            ball.ResetTimer();
            ball.gameObject.SetActive(false);
        }
        
        private void ActionOnDestroy(Ball myBall)
        {
            Destroy(myBall);
        }

        private Vector3 ChooseRandomPosition()
        {
            return new Vector3( spawnPosition.position.x + Random.Range(-spawnPositionOffset, spawnPositionOffset),
                                            spawnPosition.position.y ,
                                         spawnPosition.position.z + Random.Range(-spawnPositionOffset, spawnPositionOffset));
        }
    }
}
