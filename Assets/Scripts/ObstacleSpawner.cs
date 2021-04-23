using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject spike;
    public GameObject box;
    private GameObject objectToSpawn;
    private GameObject newSpike;
    private float xPosition = 0;
    private float zPosition = 20;

    // Start is called before the first frame update
    void Start()
    {
        
        //box.transform.localScale = new Vector3(2.5f, 1.5f, 2.5f);
        for (int i = 0; i < 10; i++)
        {
            setObjectofSpawn();
            setXPosition();

            if(objectToSpawn == box)
            {
                Instantiate(box, new Vector3(xPosition, 1.5f, zPosition), box.transform.rotation);
            }
            else if(objectToSpawn == spike)
            {         
                Instantiate(spike, new Vector3(xPosition - 1, 1.1f, zPosition), spike.transform.rotation);
            }
            zPosition += 20;            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void setObjectofSpawn()
    {
        int randNum = Random.Range(0, 101);
        
        if(randNum < 31)
        {
            objectToSpawn = box;
        }
        else if (randNum >= 31 && randNum < 61)
        {
            objectToSpawn = spike;
        }
        else
        {
            objectToSpawn = null;
        }
    }

    private void setXPosition()
    {
        int randNum = Random.Range(0, 3);
        //Far Left
        if(randNum == 0)
        {
            xPosition = 0;
        }//Middle
        else if(randNum == 1)
        {
            xPosition = 5;
        }//Far Right
        else
        {
            xPosition = 10;
        }
    }

}
