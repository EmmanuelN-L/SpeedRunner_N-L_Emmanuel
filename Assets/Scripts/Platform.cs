using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Renderer rend;
    //public GameObject obstacle1;
    

    public bool redPlatform;
    public bool greenPlatform;
    public bool bluePlatform;

    private GameObject playerCharacter;
    private PlayerMovement pm;

    // Start is called before the first frame update
    void Start()
    {
        playerCharacter = GameObject.FindGameObjectWithTag("Player");
        pm = playerCharacter.GetComponent<PlayerMovement>();

        int randomNumber = Random.Range(0, 3);

        if(randomNumber == 0)
        {
            rend.material.color = Color.red;
            redPlatform = true;

        }
        else if (randomNumber == 1)
        {
            rend.material.color = Color.green;
            greenPlatform = true;

        }
        else
        {
            rend.material.color = Color.blue;
            bluePlatform = true;
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (redPlatform)
            {
                pm.setVelocity(4f);
                Debug.Log("Red");
            }
            else if (greenPlatform)
            {
                pm.setVelocity(10f);
            }
            else if (bluePlatform)
            {
                pm.setVelocity(7f);
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pm.setVelocity(5f);
            //Debug.Log("Reset");
        }
    }

}
