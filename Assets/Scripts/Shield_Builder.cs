using UnityEngine;
using System.Collections;

public class Shield_Builder : MonoBehaviour {
    private float BuildTime=3.0f;
    private float Temp_time=0f;
    private bool isBuild=false;

    public GameObject Shield;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    Temp_time+=Time.deltaTime;
        
        if(Temp_time>=BuildTime&&isBuild==false){
            Instantiate(Shield, transform.position, transform.rotation);
            Temp_time = 0;
            isBuild = true;
        }
	}
}
