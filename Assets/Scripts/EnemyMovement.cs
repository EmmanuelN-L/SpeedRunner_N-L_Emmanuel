using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private float positionY;

    // Start is called before the first frame update
    void Start()
    {
        positionY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, positionY, transform.position.z), player.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Debug.Log("Caught ya");
            SceneManager.LoadScene("GameOverL");
        }
    }

}
