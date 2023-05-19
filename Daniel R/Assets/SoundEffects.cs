using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    [SerializeField] private AudioClip coinGrab;
    [SerializeField] private AudioClip footsteps;
    [SerializeField] private AudioClip jump;
    [SerializeField] private AudioSource coinAudioSource;
    [SerializeField] private AudioSource footstepAudioSource;
    [SerializeField] private AudioSource jumpAudioSource;
    public static SoundEffects Instance;

    private void Awake()
    {
        Instance = this;
    }
    public void playCoinGrabSound()
    {
        coinAudioSource.PlayOneShot(coinGrab);
    }

    public void playJumpSound()
    {
        jumpAudioSource.PlayOneShot(jump);
    }

    public void playFootstepsSound()
    {
        footstepAudioSource.clip=footsteps;
        footstepAudioSource.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
