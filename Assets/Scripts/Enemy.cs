using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private PointDeterminant _pointDeterminant;
    private float speed = 5f;
    private float x;
    private float z;

    private void Start()
    {
        x = Random.Range(-1, 2);
        z = Random.Range(-1, 2);

        gameObject.transform.position = _pointDeterminant.GetRandomSpawnPoint();
    }

    private void Update()
    {
        gameObject.transform.Translate(x * speed * Time.deltaTime, 0, z * speed * Time.deltaTime);
    }
}

