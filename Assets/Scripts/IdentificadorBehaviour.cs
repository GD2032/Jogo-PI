﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentificadorBehaviour : MonoBehaviour
{

    [SerializeField]
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D colapse)
    {
        if(colapse.tag == "Sacola" || colapse.tag == "Obstaculo")
        {
           player.GetComponent<playerBehaviour>().animationEat();
        }


    }
   
}