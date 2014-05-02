using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {

	private float xPos = 0.0f;
	private float yPos = 0.0f;
	private int check = 0;
	private int rNumber = Random.Range(-1,1);
	void Start () {
		this.rigidbody2D.velocity = new Vector2(rNumber, 5.0f);
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		xPos = this.transform.position.x;
		yPos = this.transform.position.y;

		if (xPos < -2.2) {
			this.rigidbody2D.velocity = new Vector2 (1, 0);
			print ("vector" + this.transform.position.x);
		} 
		else if(xPos > 2.2){
			this.rigidbody2D.velocity = new Vector2 (-1, 0);
		}


	}
	

}
