using UnityEngine;
using System.Collections;
public class BasketBallForse : MonoBehaviour {
    public float forse = 0.1f;
    public float addForse;
    public float randomNumber;
 
    void Start() {
        randomNumber = Random.Range(2, 45);
        addForse = forse * randomNumber;
    }
	void Update () {
        GetComponent<Rigidbody2D>().AddForce(-Vector2.right * addForse);     
        Destroy(this.gameObject,8f);
	}
}
