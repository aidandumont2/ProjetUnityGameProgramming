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

    public scriptPlayer player;

    private void Start()
    {

        Puissance = Random.Range(minPuissance, maxPuissance);
        puissanceEnnemis.text = $"LV {Puissance}";
        player = FindObjectOfType<scriptPlayer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == Joueur.tag)
        {
            int JoueurPuissance = player.CurrentPuissance;
            if (Puissance <= JoueurPuissance)
            {
                player.AddPuissance(Puissance);
                Debug.Log(player.CurrentPuissance);
                Destroy(gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }

}
