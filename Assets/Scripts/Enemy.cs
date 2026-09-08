using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 5f;
    private Vector3 _direction;

    private void Update()
    {
        gameObject.transform.Translate(_direction * _speed * Time.deltaTime);
    }

    public void GetDirection(Vector3 newDirection) 
    {
        _direction = newDirection;
    }
}

 