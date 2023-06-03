using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterSoundManager : MonoBehaviour
{
    public AudioClip[] movementSounds;
    public float minMoveSpeed = 0.1f;

    private AudioSource audioSource;
    private bool isMoving;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        isMoving = false;
    }

    private void Update()
    {
        // Check if the character is moving
        float moveSpeed = GetComponent<Rigidbody>().velocity.magnitude;
        bool movingNow = moveSpeed >= minMoveSpeed;

        // Play a random sound when the character starts moving
        if (!isMoving && movingNow)
        {
            PlayRandomSound();
        }

        isMoving = movingNow;
    }

    private void PlayRandomSound()
    {
        // Choose a random sound from the array
        if (movementSounds.Length > 0)
        {
            int randomIndex = Random.Range(0, movementSounds.Length);
            AudioClip randomClip = movementSounds[randomIndex];

            // Play the sound
            audioSource.clip = randomClip;
            audioSource.Play();
        }
    }
}