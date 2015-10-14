using UnityEngine;
using System.Collections;

public class BG_Builder : MonoBehaviour {
    public float Temp_Time = 0;
    public float Build_Time = 2;
    public GameObject BackGround;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Temp_Time += Time.deltaTime;
        if(Temp_Time>Build_Time){
            Instantiate(BackGround, transform.position, transform.rotation);
            Debug.Log("1");
            Temp_Time = 0;
        }
	}
}
