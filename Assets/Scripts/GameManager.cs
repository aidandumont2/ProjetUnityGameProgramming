using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public int nbEnnemi;
    public TextMeshProUGUI AffichageLevel;
    private UILevel _level;

    private void Awake()
    {
        _level=FindObjectOfType<UILevel>();
    }
    private void Start()
    {
        _level.affichagelevel(SceneManager.GetActiveScene().buildIndex);
    }

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
