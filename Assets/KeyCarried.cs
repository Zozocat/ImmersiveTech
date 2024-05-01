using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class KeyCarried : MonoBehaviour
{
    public AudioClip key_jingle;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


        public void keysJingle()
    {
        GetComponent<AudioSource>().PlayOneShot(key_jingle);
    }
}

//AI was used to help write this script