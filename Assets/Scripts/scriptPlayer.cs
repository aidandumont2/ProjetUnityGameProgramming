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

    private void Start()
    {
        transform.position = new Vector3(2.5f, 0.1f, 0);
    }

    private void Update()
    {
        puissanceText.text = $"LV {CurrentPuissance}";

        if (Input.GetButtonDown("Horizontal")) {
            float x = Input.GetAxisRaw("Horizontal");
            transform.position += new Vector3(x * speed, 0, 0);
        }
        if (Input.GetButtonDown("Vertical"))
        {
            float y = Input.GetAxisRaw("Vertical");
            transform.position += new Vector3(0, y * speed, 0);
        }

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
