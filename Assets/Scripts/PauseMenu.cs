using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool pause = false;
    [SerializeField]
    private GameObject menuUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausado();
        }
    }
    public void Resume() {

        menuUI.SetActive(false);
        Time.timeScale = 1f;
        pause = false; 
    }
    public void Pausado() {
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }
}
