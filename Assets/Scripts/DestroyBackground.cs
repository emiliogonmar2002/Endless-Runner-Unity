using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBackground : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Background")){
            Destroy(other.gameObject);
        }
    }
}
