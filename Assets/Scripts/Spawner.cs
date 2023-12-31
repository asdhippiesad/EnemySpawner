using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private Coroutine _spawnCoroutine;
    private float _spawnInterval = 2.0f;

    private void Start()
    {
        _spawnCoroutine = StartCoroutine(SpawnEnemy());
    }

    private void OnDestroy()
    {
        if (_spawnCoroutine != null)
        {
            StopCoroutine(_spawnCoroutine);
        }
    }

    private IEnumerator SpawnEnemy()
    {
        bool isWorking = true;
        var waitForSecond = new WaitForSeconds(_spawnInterval);
        int spawnPointIndex = 0;

        while (isWorking)
        {
            yield return waitForSecond;

            SpawnPoint spawnPoint = _spawnPoints[spawnPointIndex];
            spawnPoint.SpawnEnemy();
        }
    }
}
