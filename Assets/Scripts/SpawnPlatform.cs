using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{

    [SerializeField] private GameObject[] _platformPrefabs;
    [SerializeField] private BoxCollider2D _boxCollider2D;
    [SerializeField] private float _gapLowLimit=0;
    [SerializeField] private float _gapHighLimit=3;

    private void Update() {
        if(transform.position.x < 1) {
            Vector3 spawnPosition = new Vector3(transform.position.x + _boxCollider2D.bounds.size.x + Random.Range(_gapLowLimit,_gapHighLimit),0);
            Instantiate(_platformPrefabs[Random.Range(0,_platformPrefabs.Length)],spawnPosition,Quaternion.identity);
            enabled = false;
        }
    }
}
