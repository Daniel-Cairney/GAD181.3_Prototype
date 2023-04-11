using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject cube;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Destroy");
        Destroy(cube);
    }
}
