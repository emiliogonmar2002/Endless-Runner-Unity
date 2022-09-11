using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    // [SerializeField] AudioSource _audioSource;

    public void PlaySfx(AudioClip clip) {
        // _audioSource.clip() = clip;
        // _audioSource.Play();

        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
