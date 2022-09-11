using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _obstaclePrefabs;
    private bool _spawnActivated=true;
    private GameObject _spawnedObject;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObstacle());   
    }

    IEnumerator SpawnObstacle() {
        while (_spawnActivated) {
            yield return new WaitForSeconds(Random.Range(1,4));
            _spawnedObject = Instantiate(_obstaclePrefabs[Random.Range(0,4)], transform.position, Quaternion.identity);
        }
    }
}
