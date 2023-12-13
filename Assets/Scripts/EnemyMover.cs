using System.Collections;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private int _speed;

    private Coroutine _coroutine;

    private void Start()
    {
       _coroutine = StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        bool isWorking = true;

        while (isWorking)
        {
            yield return null;
            transform.position += transform.forward * _speed * Time.deltaTime;
        }
    }
}
