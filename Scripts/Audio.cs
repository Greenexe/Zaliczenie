using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    static AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    public static void PlayLoopSound(AudioClip clip)
    {
        if (audioSource.isPlaying == false)
        {
            audioSource.Play();
        }
    }

    public static void StopLoopSound()
    {
        if (audioSource.isPlaying == true)
        {
            audioSource.Pause();
        }
    }
}
