using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIN : CountTime
{
    void Start()
    {
        startTime = Time.time; 
    }
    void Update()
    {
        Tempo(startTime);
        if (actualTime >= 11.5f && gameObject.tag == "AberturaCena")
        {
            Destroy(this.gameObject);
        }

        if (actualTime >=6 && gameObject.tag == "Pontuacao")
        {
            
        }
    }
}
