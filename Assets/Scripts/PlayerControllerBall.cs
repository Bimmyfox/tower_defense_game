using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBall : MonoBehaviour
{
    private float speed = 10.0f;
    private float verticalInput;
    private float horizontalInput;
    private Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ReadInput();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }
       
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Tower"))
        {
            Debug.Log($"Hit {other.gameObject.name}");
        }
    }

    void ReadInput()
    {
        verticalInput = Input.GetAxis("Vertical");     
        horizontalInput = Input.GetAxis("Horizontal");
    }

    void MovePlayer()
    {
        playerRb.AddForce(Vector3.forward * speed * verticalInput);// * Time.fixedDeltaTime);     
        playerRb.AddForce(Vector3.right * speed * horizontalInput);// * Time.fixedDeltaTime);     
    }
}
