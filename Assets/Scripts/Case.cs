using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Case : MonoBehaviour
{
    public GameObject playerPosition;
    public scriptPlayer player;
    public float speed = 10f;
    Vector2 lastClickedPos;
    bool moving;

    private void Start()
    {
        player = FindObjectOfType<scriptPlayer>();
    }
    private void OnMouseDown()
    {
        player.transform.position = playerPosition.transform.position;
        /*if (Input.GetMouseButtonDown(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
            int i = 0;
            i += 1;
            Debug.Log("Case Clicked " + i + "times");
        }
        if (moving && (Vector2)playerController.transform.position != lastClickedPos)
        {
            float step = speed * Time.deltaTime;
            playerController.transform.position = Vector2.MoveTowards(playerPosition.transform.position, lastClickedPos, step);
        }
        else
        {
            moving = false;
        }*/
        
        
    }
}
