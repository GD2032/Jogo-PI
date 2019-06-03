using System.Collections;
using Assets.Scripts;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicialButton : CountTime
{
   [SerializeField] private GameObject canvas;
   [SerializeField] private GameObject fade;
   [SerializeField] private GameObject background;
    private float actualTime = 10000000f;
    public static string sceneName;
    

    public void CarregarJogo(string sceneNam)
    { 
        Destroy(this.background);
        Instantiate(fade);
        actualTime = Tempo(-1);
        sceneName = sceneNam;
    }
    public float GetActualTime()
    {
        return actualTime;
    }

}
