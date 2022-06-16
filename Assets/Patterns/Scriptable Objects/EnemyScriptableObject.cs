using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptableObject", menuName = "ScriptableObjects/Enemy")]
public class EnemyScriptableObject : ScriptableObject
{
    [SerializeField] public int health  = 100;
    [SerializeField] public float speed  = 5f;
    [SerializeField] public EnemyAttackSciptableObject enemyAttack;
}
