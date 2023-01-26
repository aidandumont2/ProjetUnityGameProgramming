using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int nbEnnemi;
    internal void DecrementEnnemiCount()
    {
        nbEnnemi--;

        if (nbEnnemi <= 0)
        {
            Debug.Log("fini");
            NextLevel();
        }
    }
    private static void NextLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex + 1);
    }
}
