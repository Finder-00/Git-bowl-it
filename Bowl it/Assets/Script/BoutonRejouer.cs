using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonRejouer : MonoBehaviour
{
    
    public void relance()
    {
        SceneManager.LoadScene(1);
    }

    public void quitter()
    {
        Application.Quit();
    }
}