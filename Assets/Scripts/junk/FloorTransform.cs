using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTransform : MonoBehaviour
{

    [SerializeField] GameObject _spawn;

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Floor")){
           other.transform.position = _spawn.transform.position;
        }
    }
}
