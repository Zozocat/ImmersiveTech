using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MonsterNoise : MonoBehaviour
{
    public AudioClip foot_step_audio;
    public int footstepswait = 10;
    bool keepPlaying = true;

    private AudioSource audioSource;
    private Transform player;
    private float maxDistance = 10.0f; 


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player = Camera.main.transform;
        StartCoroutine(SoundOut());
    }

    IEnumerator SoundOut()
    {
        while (keepPlaying)
        {
            GetComponent<AudioSource>().PlayOneShot(foot_step_audio);
            Debug.Log("hehe im following you");
            yield return new WaitForSeconds(footstepswait);

            float distance = Vector3.Distance(transform.position, player.position);
            if (distance > maxDistance)
            {
                keepPlaying = false;  // Stop playing when player leaves the room
                break;
            }

            float volume = Mathf.Lerp(1.0f, 0.0f, distance / maxDistance);
            audioSource.volume = volume;
        }
    }

    void OnDisable()
    {
        keepPlaying = false;
    }
}
