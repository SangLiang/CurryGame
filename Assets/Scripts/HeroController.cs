using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {

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
            //Destroy(col.gameObject);
            StartCoroutine(GoNextto());

        }
    }


    IEnumerator GoNextto()
    {
        yield return new WaitForSeconds(0.8f);
        Application.LoadLevel(1);
    }

}
