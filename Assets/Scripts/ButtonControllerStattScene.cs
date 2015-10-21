using UnityEngine;
using System.Collections;

public class ButtonControllerStattScene : MonoBehaviour
{

    // Use this for initialization
   public void StartGame()
    {
        StartCoroutine(StartGameWaitFor());
    }
   public void ExitGame()
    {
        Application.Quit();
    }

   IEnumerator StartGameWaitFor() {
       yield return new WaitForSeconds(0.5f);
       Application.LoadLevel("Stage_01");

   }
}
