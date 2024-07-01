using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float startSpawnDelay;
    [SerializeField] private float spawnInterval;
    [Space]
    [SerializeField] private List<EnemyController> enemies;

    private Vector3 _pointToSpawn;
    private void Awake()
    {

    }
    private void Start()
    {
        StartCoroutine(SpawnWithInterval());
    }
    private IEnumerator SpawnWithInterval()
    {
        yield return new WaitForSeconds(startSpawnDelay);

        foreach (var enemy in enemies)
        {
            float randomPoint = Random.Range(transform.position.x - 10, 10);
            _pointToSpawn = new Vector3(randomPoint, transform.position.y, randomPoint);
            ObjectPool.PoolInstantiate(enemy, _pointToSpawn);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
