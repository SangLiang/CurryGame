using UnityEngine;
using System.Collections;
//using DG.Tweening;
public class Panel : MonoBehaviour
{
    public GameObject gameDeveloperPanel;


    public void GameDeveloperPanel_In()
    {

        iTween.MoveTo(gameDeveloperPanel, new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0), 1.2f);
    }

    public void GameDeveloperPanel_Out()
    {

        iTween.MoveTo(gameDeveloperPanel, new Vector3(Screen.width * 0.5f, Screen.height * 1.5f, 0), 1.2f);
    }
}
