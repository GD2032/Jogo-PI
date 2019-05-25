using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIN : MonoBehaviour
{
 
    void Start()
    {

    }


    void Update()
    {
      
        if (Time.time >= 10)
        {
            Destroy(this.gameObject);
        }
    }
}
