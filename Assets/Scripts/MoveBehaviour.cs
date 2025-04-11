using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{

    private Rigidbody playerRigidbody;

    public float moveSpeed;
    public float rotationSpeed;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        

        if (Input.GetKey(KeyCode.W))
        {
            // Move forward
            MovePosition(1);
        }   

        if (Input.GetKey(KeyCode.S))
        {
            // Move backward
            MovePosition(-1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // Rotate left
            RotatePlayer(-1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Rotate right
            RotatePlayer(1);
        }
    }
    private void RotatePlayer(int num)
    {
        playerRigidbody.MoveRotation(Quaternion.Euler(transform.localRotation.eulerAngles + Vector3.up * rotationSpeed * Time.deltaTime * num));
    }

    private void MovePosition(int num)
    {
        playerRigidbody.MovePosition(transform.position + transform.forward * moveSpeed * Time.deltaTime * num);
    }

}