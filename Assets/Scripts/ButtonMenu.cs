using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReturnMenu()
    {
        Debug.Log("User clicked on Retour au Menu");

        SceneManager.LoadScene("Menu");
        //SceneManager.LoadScene(1);
    }
}
