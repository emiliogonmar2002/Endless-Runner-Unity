using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGem : MonoBehaviour
{
    [SerializeField] private AudioController _audioController;
    [SerializeField] private AudioClip _collectClip;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Item")){
            GetComponent<GemsCollected>().CollectItem(other);
            _audioController.PlaySfx(_collectClip);
        }
    }
}
