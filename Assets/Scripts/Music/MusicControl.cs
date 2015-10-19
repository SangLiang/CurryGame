using UnityEngine;

using System.Collections;

public class MusicControl : MonoBehaviour {
    private AudioSource audio;
    public AudioClip startMusic;
    public AudioClip ballSound;
    public AudioClip GameOverSound;


    public static MusicControl _instant;
    void Awake() {
        _instant = this;
        audio = this.GetComponent<AudioSource>();
    }

    public void StartStartMusic() {
        audio.PlayOneShot(startMusic);
    }

    public void PlayBallSound() {
        audio.PlayOneShot(ballSound);
    }

    public void PlayGameOverSound() {
        audio.PlayOneShot(GameOverSound);
    }

}
