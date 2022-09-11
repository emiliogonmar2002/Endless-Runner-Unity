using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetYPos : MonoBehaviour
{
    [SerializeField] private float _yHighMin;
    [SerializeField] private float _yHighMax;

    void Start()
    {
        Vector2 currentPosition = transform.position;
        currentPosition.y = Random.Range(_yHighMin,_yHighMax);
        transform.position = currentPosition;
    }
}
