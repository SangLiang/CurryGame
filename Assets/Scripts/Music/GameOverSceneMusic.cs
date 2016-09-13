using UnityEngine;
using System.Collections;

public class GameOverSceneMusic : MonoBehaviour {

	void Start () {
        MusicControl._instant.PlayGameOverSound();
	}
	
}
