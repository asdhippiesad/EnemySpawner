using System.Collections;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemy;
    [SerializeField] private Transform _transform;

    public void Awake()
    {
        EnemyMover newEnemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        newEnemy.AssignTargetObject(_transform);
    }
}