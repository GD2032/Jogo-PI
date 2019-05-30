using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medusaBehaviour : CountTime
{
    float aceleracao;
    void Start()
    {
        aceleracao = 1.5f;
    }
    void Update()
    {
        transform.position += new Vector3(-2f, 0) * aceleracao *  Time.deltaTime;
        aceleracao -= 0.02f;
        if (aceleracao <= 0.1)
        {
            aceleracao = 1.4f;
        }
    }
}
