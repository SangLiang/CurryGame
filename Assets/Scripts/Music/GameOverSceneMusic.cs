using UnityEngine;
using System.Collections;

public class GameOverSceneMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MusicControl._instant.PlayGameOverSound();
	}
	
	
}
