using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearFish : CountTime
{

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(-5, 0) * Time.deltaTime  ;
        if (transform.position.x < -10f)
        {
            Destroy(this.gameObject);
        }
    }
}
