using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-6, 0);
    }
}
