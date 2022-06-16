using UnityEngine;

[CreateAssetMenu(fileName = "EnemyAttackScriptableObject", menuName = "ScriptableObjects/EnemyAttack")]
public class EnemyAttackSciptableObject : ScriptableObject
{
    public float attackDamage  = 10f;
    public float attackRange  = 10f;
    public AudioClip attackSound;
}
