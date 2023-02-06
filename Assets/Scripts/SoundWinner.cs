using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundWinner : MonoBehaviour
{
    public AudioClip[] winSounds;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayWinSound()
    {
        source.clip = winSounds[Random.Range(0, winSounds.Length)];
        source.Play();
    }
}
