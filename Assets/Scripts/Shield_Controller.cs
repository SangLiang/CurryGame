using UnityEngine;
using System.Collections;

public class Shield_Controller : MonoBehaviour {
    void Start() {
        Destroy(this.gameObject,10f);
    }


    void OnCollisionEnter2D(Collision2D col) { 
        if( col.gameObject.tag=="Player"){
            Destroy(this.gameObject);
            MusicControl._instant.PlayAwardSound();
        }
    }

}
