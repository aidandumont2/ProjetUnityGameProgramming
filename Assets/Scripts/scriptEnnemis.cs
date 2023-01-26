using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class scriptEnnemis : MonoBehaviour
{

    public GameObject Joueur;

    public int minPuissance;
    public int maxPuissance;
    private int Puissance;

    public TextMeshProUGUI puissanceEnnemis;

    private void Start()
    {

        Puissance = Random.Range(minPuissance, maxPuissance);
        puissanceEnnemis.text = $"LV {Puissance}";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == Joueur.tag)
        {
            int JoueurPuissance = Joueur.gameObject.GetComponent<scriptPlayer>().CurrentPuissance;
            if (Puissance <= JoueurPuissance)
            {
                Joueur.gameObject.GetComponent<scriptPlayer>().CurrentPuissance += Puissance;
                Debug.Log(Joueur.gameObject.GetComponent<scriptPlayer>().CurrentPuissance);
                Destroy(gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }

}
