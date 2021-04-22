using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Renderer rend;
    public GameObject obstacle1;
    private GameObject playerCharacter;

    private PlayerMovement pm;
    public bool redPlatform;
    public bool greenPlatform;
    public bool bluePlatform;
    // Start is called before the first frame update
    void Start()
    {
        playerCharacter = GameObject.FindGameObjectWithTag("Player");
        pm = playerCharacter.GetComponent<PlayerMovement>();
        Debug.Log(pm);

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

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (redPlatform)
            {
                //pm.playerVelocity = 3f;
                pm.setVelocity(1f);
                Debug.Log("Red");
            }
            else if (greenPlatform)
            {
                //pm.playerVelocity = 7f;
                pm.setVelocity(10f);
            }
            else if (bluePlatform)
            {
                //pm.playerVelocity = 5f;
                pm.setVelocity(5f);
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //pm.playerVelocity = 5f;
            pm.setVelocity(5f);
            Debug.Log("Reset");
        }
    }

}
