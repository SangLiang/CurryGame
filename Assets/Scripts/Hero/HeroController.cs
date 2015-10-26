using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class HeroController : MonoBehaviour {
    public GameObject Light;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position.x = new Vector3( );


        transform.position = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)).x, transform.position.y,transform.position.z);
        
        
        //将鼠标坐标转换为屏幕坐标然后赋给战机的坐标
	}

    void OnCollisionEnter2D( Collision2D col) { 
       
        if(col.gameObject.tag=="Enemy"){
            if(GameObject.Find("LifeController").GetComponent<LifeController>().Life>1){
                Destroy(col.gameObject);
            }
            MusicControl._instant.PlayBallSound();
            Light.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
            LifeController._instance.LessLife();
            this.rigidbody2D.mass = 1;
            Debug.Log(this.rigidbody2D.mass);
        }

        if ( col.gameObject.tag=="Award"){
            Light.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
            LifeController._instance.AddLife();
            this.rigidbody2D.mass = 10;
            Debug.Log(this.rigidbody2D.mass);
        }
    }


  

}
