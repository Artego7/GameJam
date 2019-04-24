using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    GameObject player;
    GameObject block;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collision)
    {


        switch(collision.tag) {
            case "Cuadrado":
                break;
            case "Triangulo":
                break;
            case "Circulo":
                break;
        }
    }
    
       

}



