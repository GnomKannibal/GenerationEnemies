using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 5f;

    private void Update()
    {
        gameObject.transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}

 