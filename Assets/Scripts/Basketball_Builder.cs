using UnityEngine;
using System.Collections;

public class Basketball_Builder : MonoBehaviour {
    public float Temp_Time = 0;
    public float Build_Time = 2;
    public GameObject BasketBall;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Temp_Time += Time.deltaTime;
        if (Temp_Time > Build_Time)
        {
            Instantiate(BasketBall, transform.position, transform.rotation);
          
            Temp_Time = 0;
        }
    }
}
