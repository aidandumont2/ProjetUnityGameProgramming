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
    public int nbennemi = 2;

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
            int JoueurPuissance = Joueur.gameObject.GetComponent<scriptPlayer>().Puissance;
            if (Puissance <= JoueurPuissance)
            {
                Joueur.gameObject.GetComponent<scriptPlayer>().Puissance += Puissance;
                Debug.Log(Joueur.gameObject.GetComponent<scriptPlayer>().Puissance);
                Destroy(gameObject);
                GameManager gameManager = FindObjectOfType<GameManager>();
                gameManager.DecrementEnnemiCount();
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }

}
