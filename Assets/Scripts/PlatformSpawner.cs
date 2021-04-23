using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    public GameObject player;
    private float xPosition = 0;
    private float zPosition = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            xPosition = i * 5;

            for (int j = 0; j < 10; j++)
            {
                Instantiate(platform, new Vector3(xPosition, 0, zPosition), Quaternion.identity);
                zPosition += 20;
            }
            zPosition = 0;
        }

        //Instantiate(player, new Vector3(5, 10, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
