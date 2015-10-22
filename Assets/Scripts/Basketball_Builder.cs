using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Basketball_Builder : MonoBehaviour {
    public float Temp_Time = 0;
    public float Build_Time = 2f;
    public GameObject BasketBall;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Temp_Time += Time.deltaTime;
        if(Convert.ToInt32(GameObject.Find("Score_Number").GetComponent<Text>().text)>10){
            Build_Time = 1.2f;
        }
        if (Convert.ToInt32(GameObject.Find("Score_Number").GetComponent<Text>().text) > 20)
        {
            Build_Time =1.0f;
        }
        if (Convert.ToInt32(GameObject.Find("Score_Number").GetComponent<Text>().text) > 30)
        {
            Build_Time = 0.9f;
        }
        if (Convert.ToInt32(GameObject.Find("Score_Number").GetComponent<Text>().text) > 40)
        {
            Build_Time =0.8f;
        }
        if (Convert.ToInt32(GameObject.Find("Score_Number").GetComponent<Text>().text) > 40)
        {
            Build_Time = 0.7f;
        }


        if (Temp_Time > Build_Time)
        {
            Instantiate(BasketBall, transform.position, transform.rotation);
            GameObject.Find("Score_Number").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Score_Number").GetComponent<Text>().text) + 1);
            Temp_Time = 0;
        }
    }
}
