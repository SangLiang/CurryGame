using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class LifeController : MonoBehaviour {

    public static LifeController _instance;
    public int Life = 1;

    void Awake() {
        _instance = this;
    }

    void Update() { 
        if(Life==0){
            StartCoroutine(GoNextto());
        }
    }


    public void AddLife() {
        if (Life == 1) {
            Life = Life + 1;
        }
        
    }

    public void LessLife() {
        Life = Life - 1;
    }



    IEnumerator GoNextto()
    {
        yield return new WaitForSeconds(0.8f);
        PlayerPrefs.SetInt("Dead_Score", Convert.ToInt32(GameObject.Find("Score_Number").GetComponent<Text>().text));
        Application.LoadLevel("GameOverScene");
    }

}
