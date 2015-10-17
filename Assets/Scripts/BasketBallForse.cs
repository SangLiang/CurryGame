using UnityEngine;
using System.Collections;


public class BasketBallForse : MonoBehaviour {
    public float forse = 0.1f;
    public float addForse;
    public float randomNumber;
    
	// Use this for initialization
   

    void Start() {
        randomNumber = Random.Range(2, 45);
        addForse = forse * randomNumber;
    
    }
	
	
	// Update is called once per frame
	void Update () {

        rigidbody2D.AddForce(-Vector2.right * addForse);     
        Destroy(this.gameObject,8f);
	}

   

   



}
