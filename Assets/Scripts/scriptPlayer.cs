using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scriptPlayer : MonoBehaviour
{
    public float speed = 2f;
    public int Puissance;
    public TextMeshProUGUI puissanceText;
    private void Update()
    {
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
    

    private void Start()
    {
        puissanceText.text = $"LV {Puissance}";
    }

}
