using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBackground : MonoBehaviour
{
    [SerializeField] private GameObject _backgroundPrefab;
    [SerializeField] private BoxCollider2D _boxCollider2D;
    [SerializeField] private float _yPos;

    private void Update() {
        if(transform.position.x < 0) {
            Vector3 spawnPosition = new Vector3(transform.position.x + _boxCollider2D.bounds.size.x - 0.1f,6f);
            Instantiate(_backgroundPrefab,spawnPosition,Quaternion.identity);
            enabled = false;
        }
    }
}
