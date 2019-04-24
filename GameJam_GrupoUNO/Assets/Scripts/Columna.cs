using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour {


    Rigidbody2D rbColum;
    public float columVelocity;
    //bool playerLive;


	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //if (playerLive) {
        //rbColum.velocity = new Vector2(columVelocity, rbColum.velocity.y);
        //rbColum.AddForce(Vector2.up * columVelocity, ForceMode2D.Impulse);
        rbColum.velocity = new Vector2( 0.0f, columVelocity);
        //}
	}
    
}
