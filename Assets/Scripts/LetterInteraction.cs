using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LetterInteraction : MonoBehaviour
{
    public GameObject envelopeA;
    public GameObject envelopeB;
    public GameObject grid;
    public TextMeshProUGUI script;
    public TextMeshProUGUI guide;
    
    

    public void EnvelopeOpen()
    {
        envelopeA.SetActive(false);
        envelopeB.SetActive(true);
    }

    public void LetterOpen()
    {
        envelopeB.SetActive(false);
        grid.SetActive(true);

        script.text = "";
        guide.text = "CLICK TO PICK UP/DOWN AND MOVE TO OBJECTS\nALSO CLICK AND PRESS 'R' TO ROTATE OBJECTS";
    }
}
