using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Columna : MonoBehaviour {
    //cambiar el nombre del player a medida que cambia la forma y hacer la deteccion a través del nombre
    //Player player;
    //Image geometryPrefab;
    //GameObject columPrefab;
    RectTransform columRectTransform;
    public float columVelocity;
    float columXAxis;
    float columYAxis;
    float columZAxis;

    void Start () {
        //player = GetComponent<Player>();
        //geometryPrefab = GetComponent<Image>();
        //columPrefab = GetComponent<GameObject>();
        columRectTransform = GetComponent<RectTransform>();
        columXAxis = 0.0f;
        columYAxis = -2696.0f;
        columZAxis = 0.0f;
    }

    void FixedUpdate () {
            columRectTransform.anchoredPosition = new Vector3(columXAxis, columYAxis, columZAxis);
            columYAxis += columVelocity;
        if (/*!player.isAlive &&*/ columVelocity > 0.0f){
        columVelocity -= 0.4f;
        }
        if (/*!player.isAlive &&*/ columVelocity <= 0.0f)
        {
            columVelocity = 0.0f;
        //menu de muerte
        }
    }
}
