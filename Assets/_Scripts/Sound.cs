using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Sound : MonoBehaviour
    {
        public static Sound Instance;

        [SerializeField]
        private AudioSource source;
        public AudioClip music;
        public AudioClip enemydeath;
        public AudioClip dash;
        public AudioClip spawn;
        public AudioClip attack;
        public AudioClip door;


        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(this);
            }
        }

        public static void PlayEnemyDeath()
        {
            Sound.Play(Instance.enemydeath);
        }
        public static void PlayAttack()
        {
            Sound.Play(Instance.attack);
        }

        public static void PlayDoor()
        {
            Sound.Play(Instance.door);
        }

        public static void PlayDash()
        {
            Sound.Play(Instance.dash);
        }

        public static void PlaySpawn()
        {
            Sound.Play(Instance.spawn);
        }

        public static void PlayMusic()
        {
           Sound.Play(Instance.music);
        }

        public static void Play(AudioClip clip)
        {
            if (clip == null) return;
            Instance.source.PlayOneShot(clip);
        }
        
    }

