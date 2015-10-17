using UnityEngine;
using System.Collections;

public class BgMove : MonoBehaviour {
    public float Speed =3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x<-22){
            Destroy(this.gameObject);
        }
        transform.Translate(Vector2.right * Time.deltaTime * (-1) * Speed);
	}
}
