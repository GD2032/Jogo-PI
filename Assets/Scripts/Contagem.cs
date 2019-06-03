using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Contagem : MonoBehaviour
{
    [SerializeField]
    private GameObject Button;
    private float actualTime;
    void Update()
    {   
        actualTime = Button.GetComponent<MenuInicialButton>().GetActualTime();
        if (Time.time >= actualTime)
        {
            SceneManager.LoadScene(MenuInicialButton.sceneName);
            Destroy(Button);
        }
    }
}
