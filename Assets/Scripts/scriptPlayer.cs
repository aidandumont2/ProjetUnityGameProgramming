using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scriptPlayer : MonoBehaviour
{
    public float speed = 2f;

    public int Puissance;
    public int CurrentPuissance;
    public TextMeshProUGUI puissanceText;
    public GameManager indexLevel;


    private void Start()
    {
        /*transform.position = new Vector3(2.5f, 0.1f, 0);*/
    }

    private void Update()
    {
        puissanceText.text = $"LV {CurrentPuissance}";

    }
    

    private void Awake()
    {
        CurrentPuissance = Puissance;
        puissanceText.text = $"LV {Puissance}";
    }

    public void AddPuissance(int PuissanceAjoute)
    {
        CurrentPuissance += PuissanceAjoute;
    }
}
