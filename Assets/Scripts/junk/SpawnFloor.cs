using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloor : MonoBehaviour
{
    [SerializeField] private GameObject _floorPrefab;
    [SerializeField] private GameObject _spawn;
    private GameObject _floorClone;
    
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Floor")){
            _floorClone = Instantiate(_floorPrefab,_spawn.transform.position,Quaternion.identity);
        }
    }
}
