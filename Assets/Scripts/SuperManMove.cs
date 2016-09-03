using UnityEngine;
using System.Collections;

public class SuperManMove : MonoBehaviour {

	void Start () {
        iTween.MoveTo(this.gameObject, new Vector3(-5.7f, transform.position.y, transform.position.z), 35.0f);
        
	}
	
	void Update () {
            Destroy(this.gameObject,10f);
	}
}
