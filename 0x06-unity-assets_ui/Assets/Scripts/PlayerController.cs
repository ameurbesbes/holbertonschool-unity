using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float gravity = 9.81f;
    public float jumpSpeed = 2.5f;

    private CharacterController controller;

    private float directionY;
    // Start is called before the first frame update
    void Start()
    {
       controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        if (Input.GetButtonDown("Jump")){
            directionY = jumpSpeed;
        }

        directionY -= gravity * Time.deltaTime;

        direction.y = directionY;

        controller.Move(direction *  moveSpeed * Time.deltaTime);

        if(transform.position.y < -30)
        {
            transform.position = new Vector3(0, 30, 0);
        }
    }
}
