using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("User clicked on Play button");

        SceneManager.LoadScene("Level1");
        //SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("User clicked on Quit button");

        Application.Quit();
    }
}
