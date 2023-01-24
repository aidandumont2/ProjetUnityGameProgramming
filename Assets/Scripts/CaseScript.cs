using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseScript : MonoBehaviour
{
    public GameObject Ennemi;
    public GameObject Joueur;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        Debug.Log("test1");
        if (collision == Joueur)
        {
            Debug.Log("test2");
            /*if ()
            {

            }*/
        }
    }

    /*private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("oscour");
    }*/



}
