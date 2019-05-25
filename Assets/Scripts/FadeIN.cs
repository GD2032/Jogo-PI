using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIN : MonoBehaviour
{
    [SerializeField]
    GameObject fundo;
    void Start()
    {

    }


    void Update()
    {
        if ( fundo.tag =="Finish")
        {
            if (Time.time >= 3)
            {
                Destroy(fundo);
            }
        }
        if (Time.time >= 10)
        {
            Destroy(this.gameObject);
        }
    }
}
