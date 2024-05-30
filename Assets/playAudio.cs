using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource soundPlay;

    public void ToggleSound()
    {
        if (soundPlay.isPlaying)
        {
            soundPlay.Stop();
        }
        else
        {
            soundPlay.Play();
        }
    }
}
