using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGemAudio : MonoBehaviour
{
    [SerializeField] AudioSource _audioData;

    public void PlayAudio() {
        _audioData = GetComponent<AudioSource>();
        _audioData.Play(0);
    }
}
