using UnityEngine;
using System.Collections;

public class ButtonControllerStattScene : MonoBehaviour
{

    // Use this for initialization
   public void StartGame()
    {
        Application.LoadLevel("Stage_01");
    }
   public void ExitGame()
    {
        Application.Quit();
    }
}
