using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixos : MonoBehaviour
{
    public enum obstaculos{sacola, aguaViva};
     public obstaculos type;
     public GameObject objetos;
     //public GameObject[] vidas;
     public GameObject golfinho;
     private Animator anim;
    
    void Start()
    {
        golfinho = GameObject.FindWithTag("Player");
        Destroy(this.gameObject, 4);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-6, 0);
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
        Destroy(this.gameObject);
    }
}
