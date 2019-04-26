using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Geometrias : MonoBehaviour
{
    RectTransform geometryRectTransform;
    Image geometry;
    public enum FormaGeometry
    {
        Cuadrado,
        Circulo,
        Triangulo,
        Rombo,
        Pentagono
    };

    public FormaGeometry formasGeo;
    // Use this for initialization
    void Start()
    {
        geometry = GetComponent<Image>();
        geometryRectTransform = GetComponent<RectTransform>();

        switch (geometry.sprite.name)
        {
            case "Cuadrado_0":
                formasGeo = FormaGeometry.Cuadrado;
                break;
            case "Circulo_0":
                formasGeo = FormaGeometry.Circulo;
                break;
            case "Triangulo_0":
                formasGeo = FormaGeometry.Triangulo;
                break;
            case "Rombo_0":
                formasGeo = FormaGeometry.Rombo;
                break;
            case "Pentagono_0":
                formasGeo = FormaGeometry.Pentagono;
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (formasGeo.Equals(1) && geometryRectTransform.anchoredPosition == new Vector2( -100.0f, 0.0f )) {
                print("lo es");
                geometryRectTransform.anchoredPosition += new Vector2(100.0f, 0.0f);
            } else {
                geometryRectTransform.anchoredPosition += new Vector2(-50.0f, 0.0f);
            }
        }
    }

}
