using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MusicControl : MonoBehaviour {
    private AudioSource Myaudio;
    public AudioClip startMusic;
    public AudioClip ballSound;
    public AudioClip GameOverSound;
    public AudioClip AwardSound;
    public int vol;

    


   

    public static MusicControl _instant;
    void Awake() {
        _instant = this;
        Myaudio = this.GetComponent<AudioSource>();
        vol= PlayerPrefs.GetInt("Play_Numbr");
    }

    void Start() {

        if (vol == 0)
        {
            Myaudio.volume = 0;


        }

        if (vol == 1)
        {
            Myaudio.volume = 1.0f;
        }
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




    public void Music_Sclience() {
        Myaudio.volume = 0;
    }

    public void Music_Loud()
    {
        Myaudio.volume = 1;
    }

   

}
