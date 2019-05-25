using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIN : MonoBehaviour
{
    [SerializeField]
    private Camera camera;
    private GameObject Fundo;
    private SpriteRenderer FundoOpac;
    void Start()
    {
        Fundo = GameObject.FindWithTag("AberturaCena");
        FundoOpac = Fundo.transform.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        print("fundoOpac.color.a");
        if(FundoOpac.color.a >= 0.3)
        {
            camera.GetComponent<CameraBehaviour>().SetFundoOpac(true);
        }
        if (Time.time >= 10)
        {
            Destroy(this.gameObject);
        }

    }
}
