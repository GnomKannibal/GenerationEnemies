using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private PointDeterminant _pointDeterminant;

    private Vector3 _direction;

    private void Awake()
    {
        StartCoroutine(DropEnemy());

        _direction = new Vector3(Random.Range(-1, 2), 0f, Random.Range(-1, 2));

        if (_direction == Vector3.zero)
            _direction = Vector3.forward;
    }

    public IEnumerator DropEnemy() 
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

        newEnemy.transform.SetPositionAndRotation(_pointDeterminant.GetRandomSpawnPoint(), Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));
    }
}
