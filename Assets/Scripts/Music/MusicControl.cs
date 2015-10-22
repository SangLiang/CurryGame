using UnityEngine;

using System.Collections;

public class MusicControl : MonoBehaviour {
    private AudioSource Myaudio;
    public AudioClip startMusic;
    public AudioClip ballSound;
    public AudioClip GameOverSound;
    public AudioClip AwardSound;


    public static MusicControl _instant;
    void Awake() {
        _instant = this;
        Myaudio = this.GetComponent<AudioSource>();
    }

    public void StartStartMusic() {
        Myaudio.PlayOneShot(startMusic);
    }

    public void PlayBallSound() {
        Myaudio.PlayOneShot(ballSound);
    }

    public void PlayGameOverSound() {
        Myaudio.PlayOneShot(GameOverSound);
    }

    public void PlayAwardSound()
    {
        Myaudio.PlayOneShot(AwardSound);
    }

}
