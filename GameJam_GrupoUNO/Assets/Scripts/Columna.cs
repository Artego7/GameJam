using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Columna : MonoBehaviour {
    //cambiar el nombre del player a medida que cambia la forma y hacer la deteccion a través del nombre
    public Player player;
    RectTransform columRectTransform;
    public float columVelocity;
    float tempColumVelocity;
    float columXAxis;
    float columYAxis;
    float columZAxis;

    bool isEndGame;

    void Start () {
        columRectTransform = GetComponent<RectTransform>();
        columXAxis = 0.0f;
        columYAxis = -2696.0f;
        columZAxis = 0.0f;
        tempColumVelocity = columVelocity;
    }

    void FixedUpdate () {
        columRectTransform.anchoredPosition = new Vector3(columXAxis, columYAxis, columZAxis);
        columYAxis += columVelocity;

        finishLvl();
    }
    void finishLvl() {
        if (player.isMask) {
            columVelocity = tempColumVelocity / 2.0f;
        }else if (!player.isMask) {
            columVelocity = tempColumVelocity;
        }
        if (!player.isAlive && columVelocity > 0.0f) {
            columVelocity -= 0.4f;
        } else if (!player.isAlive && columVelocity <= 0.0f) {
            columVelocity = 0.0f;
            //menu de muerte
        }

        if (isEndGame) {
            //menu win
        }
    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Meta" && columVelocity > 0.0f) {
            columVelocity -= 0.8f;
        }
        if (other.gameObject.tag == "Meta" && columVelocity <= 0.0f) {
            columVelocity = 0.0f;
            isEndGame = true;
        }
    }
}
