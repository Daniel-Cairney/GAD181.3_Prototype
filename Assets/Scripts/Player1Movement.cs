using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(3f * Time.deltaTime, 0f, 0f);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 20f);
        }
    }

}