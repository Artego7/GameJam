using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Geometrias : MonoBehaviour
{
    RectTransform geometryRectTransform;
    public Player player;

    // Use this for initialization
    void Start()
    {
        geometryRectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) 
            && !player.isMeta 
            && player.isAlive) {
            if (geometryRectTransform.anchoredPosition == new Vector2( -100.0f, 0.0f )) {
                geometryRectTransform.anchoredPosition = new Vector2(100.0f, 0.0f);
            } else {
                geometryRectTransform.anchoredPosition += new Vector2(-50.0f, 0.0f);
            }
        }
    }

}
