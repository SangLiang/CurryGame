/*
* 屏幕缩放设定
*/
using UnityEngine;
using System.Collections;

public class ScreenScale : MonoBehaviour {
    void Start() {
        Screen.SetResolution(Screen.width, Screen.height, true);
    }
	
}
