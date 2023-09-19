using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed = 100f;
    float jumpForce = 10f;
    private bool isGrounded;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.6f);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;
        rb.AddForce(movement);

        // Salto
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}