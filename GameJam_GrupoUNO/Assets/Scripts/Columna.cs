using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Columna : MonoBehaviour {
    //cambiar el nombre del player a medida que cambia la forma y hacer la deteccion a través del nombre
    public Player player;
    RectTransform columRectTransform;
    public RectTransform Meta;

    public float columVelocity;
    float tempColumVelocity;

    public float columXAxis;
    public float columYAxis;
    public float columZAxis;

    bool onScreen;

    void Start () {
        columRectTransform = GetComponent<RectTransform>();
        tempColumVelocity = columVelocity;
    }

    void FixedUpdate () {
        columRectTransform.anchoredPosition = new Vector3(columXAxis, columYAxis, columZAxis);
        columYAxis += columVelocity;

        Vector3 screenPoint = Camera.main.WorldToViewportPoint(Meta.anchoredPosition);
        onScreen = screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
        print(onScreen);
        finishLvl();
    }
    void finishLvl() {
        if (player.isAlive)
        {
            if (player.isMask) {
                columVelocity = tempColumVelocity / 2.0f;
            } else if (!player.isMask) {
                columVelocity = tempColumVelocity;
            }
        }
        if (!player.isAlive) {
            if (columVelocity > 0.0f) {
                columVelocity -= 0.4f;
            } else if (columVelocity <= 0.0f) {
                columVelocity = 0.0f;
                //menu de muerte
            }
        }
        if (player.isMeta) {
            columVelocity = 0.0f;
            //menu win
        }
    }
    void OnTriggerEnter(Collider other) {

    }
}
