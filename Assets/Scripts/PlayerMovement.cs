using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerVelocity;
    private float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {

       //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        playerSpeed = playerVelocity * Time.deltaTime;
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + playerSpeed);
    }
}
