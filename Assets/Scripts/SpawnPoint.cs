using System.Collections;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    public void SpawnEnemy()
    {
        GameObject newEnemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
    }
}