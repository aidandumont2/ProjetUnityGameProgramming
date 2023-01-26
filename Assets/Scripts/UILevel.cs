using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILevel : MonoBehaviour
{
    public TextMeshProUGUI AffichageLevel;
    public GameManager level;
    private void Start()
    {
        AffichageLevel= level.GetComponent<TextMeshProUGUI>();
    }
    public void affichagelevel(int level)
    {
        AffichageLevel.text = $"LV {level}";
    }
    

}
