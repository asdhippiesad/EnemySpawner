using System.Collections;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemyMover;
    [SerializeField] private Transform _transform;

    public void SpawnEnemy()
    {
        EnemyMover newEnemy = Instantiate(_enemyMover, transform.position, Quaternion.identity);
        newEnemy.AssignTargetObject(_transform);
    }
}