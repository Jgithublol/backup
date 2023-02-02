using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoblieMove : MonoBehaviour
{

    int moblieInput = 0;

    [SerializeField]
    float moveSpeed = 1.0f;
    Rigidbody2D rb;

    [SerializeField]
    float jumpSpeed = 1.0f;
    bool grounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int moveDir = 0;
        int keyboardInput = (int)Input.GetAxisRaw("Horizontal");

        moveDir = keyboardInput + moblieInput;
        moveDir = Mathf.Clamp(moveDir, -1, 1);
        Vector2 velocity = rb.velocity;
        velocity.x = moveDir * moveSpeed;
        rb.velocity = velocity;

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    // Function for UI
    public void UpdateMoveDirection(int direction)
    {
        moblieInput = direction;
    }

    public void Jump()
    {
        if (grounded)
        {
            rb.AddForce(new Vector2(0, 100 * jumpSpeed));
            grounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        } 
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
}
