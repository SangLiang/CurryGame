using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class SuperManBuilder : MonoBehaviour {
    private int Score;
    public GameObject SuperMan;
    private bool SuperManLife=true;
    public float Times = 0;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        Score = Convert.ToInt32(GameObject.Find("Score_Number").GetComponent<Text>().text);
        
        Times += Time.deltaTime;
        

	    if(SuperManLife==true&&Times>10&&Score%15==0){
            Instantiate(SuperMan,transform.position,transform.rotation);
           
            StartCoroutine((DeadSumperManWaitFor()));
            SuperManLife = false;
        }
	}

    IEnumerator  DeadSumperManWaitFor(){
        yield return new WaitForSeconds(5f);
        SuperManLife = true;
    }

}
