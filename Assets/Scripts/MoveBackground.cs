using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] private float _speedX;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-_speedX*Time.deltaTime,0);
    }
}
