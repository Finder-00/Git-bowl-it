using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;
/*
 * Description g�n�rale
 * Script simple qui permet de g�rer deux contr�leurs sur une m�me main. Un contr�leur de base et un controleur pour les UI.
 * Mathieu Dionne
 * Derni�re modifications : 16 septembre 2021
 */
public class GestionUI : MonoBehaviour
{
    // Le controleur pour les UI
    [SerializeField]
    GameObject UIControleur;
    // Le controleur de base
    [SerializeField]
    GameObject BaseControleur;

    // L'action qui d�clence le switch de controleur
    [SerializeField]
    InputActionReference inputActionSwitch;

    // Permet de savoir le canvas est actif ou non
    bool canvasActif = false;

    // Le canvas
    [SerializeField]
    GameObject leCanvas;


    // � l'activation du script, ajout de la fonction ActiveControleurUI lorsque l'action est faite
    private void OnEnable()
    {
        inputActionSwitch.action.performed += ActiveControleurUI;
    }

    // � la d�sactivation du script, on retire la fonction ActiveControleurUI lorsque l'action est faite
    private void OnDisable()
    {
        inputActionSwitch.action.performed -= ActiveControleurUI;
    }

    private void Start()
    {
        //D�sactivation du canvas au d�part
        if (leCanvas != null)
        {
            leCanvas.SetActive(false);
        }

        //D�sactivation des components du controleur UI
        UIControleur.GetComponent<XRRayInteractor>().enabled = false;
        UIControleur.GetComponent<XRInteractorLineVisual>().enabled = false;
    }

    // Lorsque l'action associ�e au controlleur UI est faite par le joueur (bouton par exemple)
    private void ActiveControleurUI(InputAction.CallbackContext obj)
    {
        // Si canvas inactif, on l'active ainsi que les composants du controleur de UI.
        // On d�sactive le composant du controleur de base
        if (!canvasActif)
        {
            canvasActif = true;

            UIControleur.GetComponent<XRRayInteractor>().enabled = true;
            UIControleur.GetComponent<XRInteractorLineVisual>().enabled = true;

            BaseControleur.GetComponent<XRDirectInteractor>().enabled = false;

            leCanvas.SetActive(true);
        }
        else
        // Si canvas actif, on le d�sactive ainsi que les composants du controleur de UI.
        // On active le composant du controleur de base
        {
            canvasActif = false;

            UIControleur.GetComponent<XRRayInteractor>().enabled = false;
            UIControleur.GetComponent<XRInteractorLineVisual>().enabled = false;

            BaseControleur.GetComponent<XRDirectInteractor>().enabled = true;

            leCanvas.SetActive(false);
        }

    }
}
