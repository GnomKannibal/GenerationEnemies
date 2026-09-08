using System.Collections.Generic;
using UnityEngine;

public class PointDeterminant: MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPoints;

    public Vector3 GetRandomSpawnPoint() 
    {
        const int MinNumberIndex = 0;

        int index = Random.Range(MinNumberIndex, _spawnPoints.Count);

        return _spawnPoints[index].position;
    }
}
