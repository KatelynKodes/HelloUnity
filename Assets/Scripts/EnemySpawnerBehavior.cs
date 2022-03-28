using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    private EnemyMovementBehavior _spawnee;
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _spawnTime = 5.0f;
    private float _timer = 0.0f;

    private void Update()
    {
        if (_timer >= _spawnTime)
        {
            EnemyMovementBehavior spawnedEnemy = Instantiate(_spawnee, transform.position, transform.rotation);
            spawnedEnemy.Target = _target;
            _timer = 0.0f;
        }
        _timer += Time.deltaTime;
    }
}
