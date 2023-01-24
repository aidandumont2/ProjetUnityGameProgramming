using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class scriptEnnemis : MonoBehaviour
{
    public int minPuissance;
    public int maxPuissance;
    private int Puissance;
    public TextMeshProUGUI puissanceEnnemis;

    private void Start()
    {
        Puissance = Random.Range(minPuissance, maxPuissance);
        puissanceEnnemis.text = $"LV {Puissance}";
    }
    
}
