using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        // transform.position += new Vector3(-_speed*Time.deltaTime,0);
        if(!GameManager.Instance.GameOver)
            transform.position += Vector3.left * (_speed*Time.deltaTime);
    }
}
