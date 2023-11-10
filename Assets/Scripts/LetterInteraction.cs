using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterInteraction : MonoBehaviour
{
    public GameObject envelopeA;
    public GameObject envelopeB;
    public GameObject grid;

    public void EnvelopeOpen()
    {
        envelopeA.SetActive(false);
        envelopeB.SetActive(true);
    }

    public void LetterOpen()
    {
        envelopeB.SetActive(false);
        grid.SetActive(true);
    }
}
