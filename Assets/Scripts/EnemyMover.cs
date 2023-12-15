using System.Collections;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Coroutine _coroutine;
    private Transform _target;

    public void AssignTargetObject(Transform transform)
    {
        _target = transform;
    }

    private void Start()
    {
       _coroutine = StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        while (_target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
            yield return null;
        }
    }
}
