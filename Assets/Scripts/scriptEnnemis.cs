using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;


public class scriptEnnemis : MonoBehaviour
{

    public GameObject Joueur;

    public int minPuissance;
    public int maxPuissance;
    private int Puissance;

    public TextMeshProUGUI puissanceEnnemis;

    public scriptPlayer player;

    public GameManager gameManager;

    private void Start()
    {
        if (gameObject.transform.position.x - Joueur.transform.position.x <= 17)
        {
            if (gameObject.transform.position.y - Joueur.transform.position.y >= 1)
            {
                minPuissance = 6;
                maxPuissance = 12;
            }
            else
            {
                minPuissance = 1;
                maxPuissance = 4;
            }
        }
        else
        {
            minPuissance = 29;
            maxPuissance = 34;
        }
        Puissance = Random.Range(minPuissance, maxPuissance);
        puissanceEnnemis.text = $"LV {Puissance}";
        player = FindObjectOfType<scriptPlayer>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("help");
        if (collision.gameObject.tag == Joueur.tag)
        {
            int JoueurPuissance = player.CurrentPuissance;
            if (Puissance <= JoueurPuissance)
            {
                player.AddPuissance(Puissance);
                Debug.Log(player.CurrentPuissance);
                Destroy(gameObject);
                gameManager.DecrementEnnemiCount();
            }
            else
            {
                SceneManager.LoadScene(4);
            }
        }
    }

}
