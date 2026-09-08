using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private PointDeterminant _pointDeterminant;

    private Vector3 _directionNewEnemy;

    private void Awake()
    {
        StartCoroutine(EnemyAutoSpawn());     
    }

    public IEnumerator EnemyAutoSpawn() 
    {
        float delay = 1f;
        bool isRun = false;
        var wait = new WaitForSeconds(delay);

        while (isRun == false) 
        {
            Spawn();

            yield return wait;
        }
    }

    private void Spawn() 
    {
        Enemy newEnemy = Instantiate(_enemy);

        newEnemy.transform.position = _pointDeterminant.GetRandomSpawnPoint();

        _directionNewEnemy = new Vector3(Random.Range(-1, 2), 0f, Random.Range(-1, 2));

        if (_directionNewEnemy == Vector3.zero)
            _directionNewEnemy = Vector3.forward;

        newEnemy.TakeDirection(_directionNewEnemy);
    }
}
