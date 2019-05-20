using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixos: MonoBehaviour
{

    private enum obstaculos{sacola, aguaViva};
    [SerializeField]
     private obstaculos type;
     private GameObject objetos;
     //public GameObject[] vidas;
     private Animator anim;
    
    void Start()
    {
        Destroy(this.gameObject, 4);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Vector3.up * Time.deltaTime * 6);
    }
    void OnTriggerEnter2D(Collider2D colapse)
    {
        switch (type)
        { 
         case obstaculos.sacola:
            break;
        case obstaculos.aguaViva:
            break;
        }
        if (colapse.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
