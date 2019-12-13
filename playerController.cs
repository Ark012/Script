using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] private Rigidbody Player;
    [SerializeField] private int speed;
    [SerializeField] private int jumpForce;

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        Player.AddForce(movement * speed);

        if (Input.GetKey("Jump"))
        {
            Player.AddForce(Vector2.up * jumpForce);
        }


    }
}
