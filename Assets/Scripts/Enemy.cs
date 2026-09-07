using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private PointDeterminant _pointDeterminant;
    private float _speed = 5f;
    private Vector3 _direction;
   

    private void Start()
    {
        _direction = new Vector3(Random.Range(-1, 2), 0f, Random.Range(-1, 2));

        if (_direction == Vector3.zero)
            _direction = Vector3.forward;

        gameObject.transform.position = _pointDeterminant.GetRandomSpawnPoint();
    }

    private void Update()
    {
        gameObject.transform.Translate(_direction * _speed * Time.deltaTime);
    }
}

