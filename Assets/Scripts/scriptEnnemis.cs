using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class scriptEnnemis : MonoBehaviour
{
    public int Puissance;
    public TextMeshProUGUI puissanceEnnemis;

    private void Start()
    {
        puissanceEnnemis.text = $"LV {Puissance}";
    }
    
        

    
}
