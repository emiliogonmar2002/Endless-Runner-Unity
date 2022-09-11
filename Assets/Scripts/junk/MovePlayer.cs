using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    private bool facingRight = true;
    [SerializeField] private Animator animator;

    [SerializeField] private float _speed;
    void FixedUpdate()
    {
        float _x=0,_y=0;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            _x = -1;
            if (facingRight){
                Flip();
            }
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
            _x = 1;
            if (!facingRight){
                Flip();
            }
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) _y = -1;

        transform.position += new Vector3(_speed*Time.deltaTime*_x,_speed*Time.deltaTime*_y);

        // animator.SetFloat("X_Speed", Mathf.Abs(_x));

    }

    void Flip() {
        Vector2 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;

        facingRight = !facingRight;
    }
}
