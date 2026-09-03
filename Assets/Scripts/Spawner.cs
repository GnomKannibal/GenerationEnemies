using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private void Awake()
    {
        StartCoroutine(DropEnemy());
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
    }
}
