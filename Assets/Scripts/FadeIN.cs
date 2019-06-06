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
        actualTime = Tempo(startTime);
        if (actualTime >= 8f && gameObject.tag == "AberturaCena")
        {
            Destroy(this.gameObject);
        }

        if (actualTime >=6 && gameObject.tag == "Pontuacao")
        {
            
        }
    }
}
