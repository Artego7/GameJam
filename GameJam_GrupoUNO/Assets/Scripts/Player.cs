using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    Geometrias geometria;
    Image imagePlayer;
    Animator animatorPly;
    public bool isAlive;
    public float delay = 0f;
    public string[] nameGeo = new string[] 
    {
        "G_Cuadrado_PNG",
        "G_Circulo_PNG",
        "G_Triangulo_PNG",
        "G_Rombo_PNG",
        "G_Pentagono_PNG"
    };

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
        imagePlayer = GetComponent<Image>();
        isAlive = true;
        imagePlayer.sprite.name = nameGeo[Random.Range(0, 4)];
        print(imagePlayer.sprite.name);
        SetGeometry();
    }

    private void SetGeometry()
    {
        switch (imagePlayer.sprite.name)
        {
            case "G_Cuadrado_PNG":
                formasPly = FormaPlayer.Cuadrado;
                animatorPly.SetBool("Idle_Cuadrado", true);
                this.gameObject.tag = "Cuadrado";
                print(formasPly);
                break;
            case "G_Circulo_PNG":
                formasPly = FormaPlayer.Circulo;
                animatorPly.SetBool("Idle_Circle", true);
                this.gameObject.tag = "Circulo";
                print(formasPly);
                break;
            case "G_Triangulo_PNG":
                formasPly = FormaPlayer.Triangulo;
                animatorPly.SetBool("Idle_Triangle", true);
                this.gameObject.tag = "Triangulo";
                print(formasPly);
                break;
            case "G_Rombo_PNG":
                formasPly = FormaPlayer.Rombo;
                animatorPly.SetBool("Idle_Rombo", true);
                this.gameObject.tag = "Rombo";
                print(formasPly);
                break;
            case "G_Pentagono_PNG":
                formasPly = FormaPlayer.Pentagono;
                animatorPly.SetBool("Idle_Pentagono", true);
                this.gameObject.tag = "Pentagono";
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

            animatorPly.SetBool("Idle_Cuadrado", false);
            animatorPly.SetBool("Idle_Circle", false);
            animatorPly.SetBool("Idle_Triangle", false);
            animatorPly.SetBool("Idle_Rombo", false);
            animatorPly.SetBool("Idle_Pentagono", false);

            animatorPly.SetBool("Dead", true);
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
            print(isAlive);
        }
    }
}



