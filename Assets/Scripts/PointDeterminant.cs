using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PointDeterminant: MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnPoints;

    public Vector3 GetRandomSpawnPoint() 
    {
        int index = Random.Range(0, _spawnPoints.Count);

        return _spawnPoints[index].transform.position;
    }
}
