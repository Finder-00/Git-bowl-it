using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoueurScript : MonoBehaviour
{                                                                                                   
    public int points;
    public Text textePoints;


    void Start()
    {
        points = 0;   
    }

    void Update()
    {
        textePoints.text = points.ToString();
    }
}
                                                              