using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JoueurScript : MonoBehaviour
{                                                                                                   
    public static float points;
    public TextMeshProUGUI textePoints;


    void Start()
    {
        //textePoints = GetComponent<Text>();
        points = 0;
        textePoints = GetComponent<TextMeshProUGUI>();
        Debug.Log(textePoints);
    }

    void Update()
    {
        textePoints.text = points.ToString();
    }
}
                                                              