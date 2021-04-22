using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Renderer rend;
    public GameObject obstacle1;
    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = Random.Range(0, 3);

        if(randomNumber == 0)
        {
            rend.material.color = Color.red;

        }
        else if (randomNumber == 1)
        {
            rend.material.color = Color.green;

        }
        else
        {
            rend.material.color = Color.blue;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
