﻿using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaBehavior : CountTime
{
    void Start()
    {
    }

    void Update()
    {
        transform.position += new Vector3(-9, 0) * Time.deltaTime;
        if (transform.position.x <= -17)
        {
            Destroy(this.gameObject);
        }
    }
}
