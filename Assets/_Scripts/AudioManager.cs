using System;
using UnityEngine;

[System.Serializable]
public class AudioEvent
{
    public string name;
    public AudioClip[] sounds;
    [Range(0f, 1f)]
    public float volume = 1f;
    [Range(0.1f, 3f)]
    public float pitch = 1f;
    public bool loop = false;

    [HideInInspector]
    public AudioSource source;
}

public class AudioManager : MonoBehaviour
{
    public AudioEvent[] audioEvents;

    private void Awake()
    {
        foreach (AudioEvent audioEvent in audioEvents)
        {
            audioEvent.source = gameObject.AddComponent<AudioSource>();
            audioEvent.source.volume = audioEvent.volume;
            audioEvent.source.pitch = audioEvent.pitch;
            audioEvent.source.loop = audioEvent.loop;
        }
    }

    public void PlayAudioEvent(string eventName)
    {
        AudioEvent audioEvent = Array.Find(audioEvents, ae => ae.name == eventName);
        if (audioEvent == null)
        {
            Debug.LogWarning("AudioEvent: " + eventName + " not found!");
            return;
        }

        if (audioEvent.sounds.Length > 0)
        {
            int randomIndex = UnityEngine.Random.Range(0, audioEvent.sounds.Length);
            AudioClip sound = audioEvent.sounds[randomIndex];
            audioEvent.source.clip = sound;
            audioEvent.source.Play();
        }
    }
}