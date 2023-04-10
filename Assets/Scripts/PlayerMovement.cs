using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float jumpforce = 10;
    Rigidbody2D rb;
    private bool isJumping;
    [SerializeField] private float movementSpeed;
    [SerializeField] private int playerNumber;
    
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        WallTurn.tester = 5;
       
    }

    private void Update()
    {
        transform.Translate(movementSpeed * Time.deltaTime, 0f, 0f);

        Jump();

        if (Input.GetMouseButtonDown(0))
        {
            SwitchDirection(); 
        }
        
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false && playerNumber == 1)
        {
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);

        }
        else if (Input.GetKeyDown(KeyCode.Backspace) && isJumping == false && playerNumber == 2) 
        {
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);

        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            Debug.Log("Inground");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
            Debug.Log("jumping");
        }
    }

    public void SwitchDirection()
    {
        movementSpeed *= -1; 
    }
}
