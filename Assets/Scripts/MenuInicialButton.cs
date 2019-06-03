using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicialButton : MonoBehaviour
{

    public void CarregarJogo(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
