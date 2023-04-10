using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WallTurn : MonoBehaviour
{
    //private bool isAtWall;
    //[SerializeField] private GameObject player1; 
    //[SerializeField] private GameObject player2; 

    public static int tester = 4;
    public bool hello; 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //IsAtWall= true;
            //  Player.GetComponent<GameObject>(); 
            //transform.Rotate(0, 0, 180);

            //collision.gameObject.GetComponent<Player2Movement>.SwitchDirection
          
            collision.gameObject.GetComponent<PlayerMovement>().SwitchDirection();
        }

        
    }


}
