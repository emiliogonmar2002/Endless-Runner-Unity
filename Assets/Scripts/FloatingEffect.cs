using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingEffect : MonoBehaviour
{
    [SerializeField] private float _upLimit;
    [SerializeField] private float _downLimit;
    [SerializeField] private float _floatingSpeed=0.001f;
    [SerializeField] private Vector3 _initPos;
    [SerializeField] private bool _direction=true;

    void Start() {
        _initPos = transform.position;
        StartCoroutine(floatEffect());
    }

    IEnumerator floatEffect() {
        yield return new WaitForSeconds(Random.Range(0f,1f));
        while(true)
        {
            yield return new WaitForSeconds(0.001f);
            if(transform.position.y < _initPos.y+_upLimit && _direction){
                transform.position += new Vector3(0,_floatingSpeed);
            }
            else if(transform.position.y > _initPos.y+_downLimit && !_direction) {
                transform.position -= new Vector3(0,_floatingSpeed);
            }
            else {
                _direction = !_direction;
            }
        }
    }
}
