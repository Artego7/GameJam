using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Columna : MonoBehaviour {

    Image geometryPrefab;
    GameObject columPrefab;
    RectTransform columRectTransform;
    //public Sprite imageSprite;
    public float columVelocity;
    float columXAxis;
    float columYAxis;
    float columZAxis;
    int imageSprite;
    //bool playerLive;


    // Use this for initialization
    void Start () {
        geometryPrefab = GetComponent<Image>();
        columPrefab = GetComponent<GameObject>();
        columRectTransform = GetComponent<RectTransform>();
        //columRectTransform.anchoredPosition = new Vector3( 0.0f, -1263.0f, 0.0f );
        //gameObject.transform.position = new Vector3( 0.0f, -1263.0f, 0.0f );
        columXAxis = 0.0f;
        columYAxis = -2696.0f;
        columZAxis = 0.0f;
        imageSprite = 0;
    }

    // Update is called once per frame
    void FixedUpdate () {
        //if (playerLive) {

        columRectTransform.anchoredPosition = new Vector3(columXAxis, columYAxis, columZAxis);
        columYAxis += columVelocity;
        GenerateColum();
        changeSide();
        //}
    }
    void GenerateColum() {
        //se ha visto todo por pantalla
        //if () {
        //    Instantiate(this);
        //    GameObject enemy = GameObject.Instantiate(columPrefab, Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        //}

    }

    void changeSide() {
        if (Input.GetKeyDown(KeyCode.J)) {
            print("Hola");
            if(imageSprite != 3) {
                imageSprite++;
            }
            geometryPrefab.sprite.name = "test_" + imageSprite;
        }
    }

}
