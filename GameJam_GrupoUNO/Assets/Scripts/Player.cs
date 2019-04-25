using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    Geometrias geometria;
    Image geometryPlayer;
    Animator animatorPly;
    public bool isAlive;
    public enum FormaPlayer {
        Cuadrado,
        Circulo,
        Triangulo,
        Rombo,
        Pentagono
    };
    FormaPlayer formasPly;

    void Start ()
    {
        animatorPly = GetComponent<Animator>();
        geometria = GetComponent<Geometrias>();
        geometryPlayer = GetComponent<Image>();
        isAlive = true;
        switch (geometryPlayer.sprite.name)
        {
            case "Cuadrado_0":
                formasPly = FormaPlayer.Cuadrado;
                this.gameObject.tag = "Cuadrado";
                print(formasPly);
                break;
            case "Circulo_0":
                formasPly = FormaPlayer.Circulo;
                this.gameObject.tag = "Circulo";
                print(formasPly);
                break;
            case "Triangulo_0":
                formasPly = FormaPlayer.Triangulo;
                this.gameObject.tag = "Triangulo";
                print(formasPly);
                break;
            case "Rombo_0":
                formasPly = FormaPlayer.Rombo;
                this.gameObject.tag = "Rombo";
                print(formasPly);
                break;
            case "Pentagono_0":
                formasPly = FormaPlayer.Pentagono;
                this.gameObject.tag = "Pentagon";
                print(formasPly);
                break;

        }
    }

    // Update is called once per frame
    void Update () {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        //if(formasPly.Equals(geometria.formasGeo)) {
        //    print(isAlive);
        //} else if (formasPly.Equals(geometria.formasGeo)) {
        //    isAlive = false;
        //    print(isAlive);
        //}

        if (collision.gameObject.CompareTag(this.gameObject.tag)) {
            print(isAlive);
        }
        else if (!collision.gameObject.CompareTag(this.gameObject.tag)) {
            isAlive = false;
            animatorPly.SetBool("Dead", true);
            print(isAlive);
        }
    }
}



