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
	void Update () {
        rbColum.AddForce(new Vector2(columVelocity, 2), ForceMode2D.Impulse);
            rbColum.gravityScale = 1.0f;
        //if (playerLive) {
        //}
	}
    
}
