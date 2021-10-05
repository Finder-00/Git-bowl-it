using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JoueurScript : MonoBehaviour
{                                                                                                   
    public static int points;
    public TMP_Text textePoints;


    void Start()
    {
        //textePoints = GetComponent<Text>();
        points = 0;
        textePoints.text = "0";
    }

    void Update()
    {
        textePoints.text = points.ToString();
    }
}
                                                              