using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralCaseSpawner : MonoBehaviour
{
    public GameObject[] Cases;
    public GameObject Spawned;


    // Start is called before the first frame update
    void Start()
    {
        for (int x=-4; x<=4; x++)
        {
            for (int y=-4; y<=4; y++) {
                var randomCase = Cases[Random.Range(0, Cases.Length)];
                if(x == 0 && y == 0)
                {

                }
                else
                {
                    Instantiate(randomCase, new Vector3(x * 10, y * 5), Quaternion.identity);
                }
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
