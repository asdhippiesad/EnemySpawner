using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private Coroutine _currentCoroutine;
    private float _spawnInterval = 2.0f;

    private void Start()
    {
        _currentCoroutine = StartCoroutine(SpawnEnemy());
    }

    private void Stop()
    {
        if (_currentCoroutine != null)
        {
            StopCoroutine(_currentCoroutine);
        }
    }

    private IEnumerator SpawnEnemy()
    {
        bool isWorking = true;
        var waitForSecond = new WaitForSeconds(_spawnInterval);
        int spawnIndex = Random.Range(0, _spawnPoints.Count);

        while (isWorking)
        {
            yield return waitForSecond;

            SpawnPoint spawnPoint = _spawnPoints[spawnIndex];
            spawnPoint.Awake();
        }
    }
}
