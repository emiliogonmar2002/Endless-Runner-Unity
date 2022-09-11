using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2D : MonoBehaviour
{

    [SerializeField] Rigidbody2D _rigidbody2D;
    [SerializeField] private float _jumpForce = 5;
    private bool _jump;
    [SerializeField] private Animator _animator;
    [SerializeField] private BoxCollider2D _boxCollider2D;
    [SerializeField] private LayerMask _groundLayer; // Pasarle la capa de ground
    [SerializeField] private AudioController _audioController;
    [SerializeField] private AudioClip _jumpClip;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGroundedFunction()) {
            _jump = true;
            _audioController.PlaySfx(_jumpClip);
        }

        _animator.SetBool("Jumping", !IsGroundedFunction());
    }

    void FixedUpdate() {
        if (_jump) {
            _jump = false;
            _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    bool IsGroundedFunction()
    {
        RaycastHit2D hit = Physics2D.BoxCast(_boxCollider2D.bounds.center, _boxCollider2D.bounds.size, 0,Vector2.down, .1f, _groundLayer);
        if(hit.collider != null) {
            return true;
        }
        return false;
    }
}
