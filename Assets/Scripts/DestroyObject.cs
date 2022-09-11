using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other) {
        // if(!other.CompareTag("Background")){
        //     Destroy(other.transform.root.gameObject);
        // }
        if(other.CompareTag("Player")){
            Destroy(other.transform.root.gameObject);
            GameManager.Instance.GameOver = true;
        }
    }
}
