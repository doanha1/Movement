using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0,20f)]
    public float moveSpeed;
    public float jumpHeight;

    private Rigidbody2D rbody;

    public GroundCheck groundCheck;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && groundCheck.touches > 0)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
        }
    }
}
