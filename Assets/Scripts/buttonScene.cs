using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScene : MonoBehaviour 
{
   public void ChangeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
