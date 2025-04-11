using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JB : MonoBehaviour
{

    public Rigidbody playerRigidbody;
    public float jumpForce = 400f;

    private int groundCollisions;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            groundCollisions++;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            groundCollisions--;
        }
    }

    void Update()
    {
        bool isGrounded = groundCollisions > 0;

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpVector = Vector3.up * jumpForce;
            playerRigidbody.AddForce(jumpVector);
        }
    }

}