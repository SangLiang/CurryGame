/*
	音量控制
*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MusicSilent : MonoBehaviour
{
	public int Vol = 1;
	void Update ()
	{
		if (GameObject.Find ("Music_Toggle").GetComponent<Toggle> ().isOn == true) {
			Vol = 0;
			PlayerPrefs.SetInt ("Play_Numbr", Vol);
		}
		if (GameObject.Find ("Music_Toggle").GetComponent<Toggle> ().isOn == false) {
			Vol = 1;
			PlayerPrefs.SetInt ("Play_Numbr", Vol);
		}
	}
}
