using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public int Temp;
    public int HighScore;
	// Use this for initialization
	void Start () {
        Temp = PlayerPrefs.GetInt("Dead_Score");
        HighScore = PlayerPrefs.GetInt("High_Score");

        if (Temp > HighScore)
        {
            HighScore = Temp;
            PlayerPrefs.SetInt("High_Score", HighScore);
        }
        GameObject.Find("High_Score_Number").GetComponent<Text>().text = Convert.ToString(HighScore);
        GameObject.Find("Score_Number").GetComponent<Text>().text = Convert.ToString(Temp);
	}
	
	// Update is called once per frame
	void Update () {
       


       
	}


   public  void ClearHighScore() {
        PlayerPrefs.SetInt("High_Score", 0);
        GameObject.Find("High_Score_Number").GetComponent<Text>().text = Convert.ToString(0);
    }

   public void ReStart() {
       Application.LoadLevel("Stage_01");
   }

   public void Exit() {
       Application.Quit();
   }


}
