using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Columna : MonoBehaviour {
    //cambiar el nombre del player a medida que cambia la forma y hacer la deteccion a través del nombre
    public RectTransform playerRectTransform;
    public Player player;
    float playerXAxis;
    float playerYAxis;
    float playerZAxis;

    public Text metrosLabel;
    public int metros;

    RectTransform columRectTransform;
    public float columVelocity;
    public float tempColumVelocity;
    public float currentTime;

    public float columXAxis;
    public float columYAxis;
    public float columZAxis;

    void Start () {
        columRectTransform = GetComponent<RectTransform>();
        tempColumVelocity = columVelocity;
        playerXAxis = playerRectTransform.anchoredPosition.x;
        playerYAxis = playerRectTransform.anchoredPosition.y;
        metrosLabel.text = "0";
        currentTime = 0.0f;
        playerZAxis = 0.0f;
    }

    void FixedUpdate () {
        if (columRectTransform.anchoredPosition.y < 6455.0f) {
            columRectTransform.anchoredPosition = new Vector3(columXAxis, columYAxis, columZAxis);
            columYAxis += columVelocity;
        }
        if(columRectTransform.anchoredPosition.y >= 6455.0f) {
            playerRectTransform.anchoredPosition = new Vector3(playerXAxis, playerYAxis, playerZAxis);
            playerYAxis -= columVelocity;
            columVelocity -= 0.8f;
        }
        if (!player.isMeta && player.isAlive) {
            metrosLabel.text = metros.ToString();
            currentTime += 0.4f;
            metros = (int)currentTime;
        }

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
