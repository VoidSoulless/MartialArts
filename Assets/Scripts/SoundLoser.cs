using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundLoser : MonoBehaviour
{
    public AudioClip[] lossSounds;
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
    public void PlayLossSound()
    {
        source.clip = lossSounds[Random.Range(0, lossSounds.Length)];
        source.Play();
    }
}
