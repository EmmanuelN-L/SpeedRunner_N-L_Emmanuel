using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float playerVelocity;
    public float jumpForce;
    

    private float playerSpeed;
    private bool isJumping = false;
    private int playerPosition = 1;
    private Rigidbody playerRigidbody;
    private Transform playerTransform;
    private Animator playerAnimator;

    public readonly int IsJumpingHash = Animator.StringToHash("IsJumping");



    // Start is called before the first frame update
    void Start()
    {
        playerTransform = transform;
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        playerSpeed = playerVelocity * Time.deltaTime;
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + playerSpeed);
    }

    public void OnMoveLeft(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (playerPosition != 0)
            {
                transform.localPosition = new Vector3(transform.localPosition.x - 5, transform.localPosition.y, transform.localPosition.z);
                playerPosition -= 1;
            }
            else
            {
                Debug.Log("Cant move left");
            }
        }
    }

    public void OnMoveRight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (playerPosition != 2)
            {
                transform.localPosition = new Vector3(transform.localPosition.x + 5, transform.localPosition.y, transform.localPosition.z);
                playerPosition += 1;
            }
            else
            {
                Debug.Log("Cant move Right");
            }
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            if (isJumping) return;

            //PlayerAnimator.SetBool(IsJumpingHash, value.isPressed);
            playerRigidbody.AddForce((playerTransform.up + playerTransform.forward) * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }

    public void setVelocity(float vel)
    {
        playerVelocity = vel;
    }

}
