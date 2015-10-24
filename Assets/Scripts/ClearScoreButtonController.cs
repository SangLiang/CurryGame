using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClearScoreButtonController : MonoBehaviour {
    public GameObject ClearScorePanel;
    private bool isPanelIn = false;
	
    public void ClearScorePanel_In() { 
        if( isPanelIn==false){
            iTween.MoveTo(ClearScorePanel, new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, transform.position.z),0.4f);
            isPanelIn = true;

        }
    }

    public void ClearScorePanel_Out()
    {
        if (isPanelIn == true)
        {
            iTween.MoveTo(ClearScorePanel, new Vector3(Screen.width * 0.5f, Screen.height * 1.5f, transform.position.z), 1.0f);
            isPanelIn = false;
        }
    }



}
