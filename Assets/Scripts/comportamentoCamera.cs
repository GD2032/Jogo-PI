using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentoCamera : MonoBehaviour
{

    //public float zoomSpeed ;
    //public float smoothSpeed = 30.0f;
   // public float minRange = 1.9f;
    //public float target;
 
    public float speed;
    public float ymax = 4.769569f;
    public GameObject personagem;
    float variavel;
    void Start()
    {
    }
    void Update()
    {
        variavel = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * variavel * speed * Time.deltaTime);
        Limite();
       // Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, playerBehaviour.posicaoPersonagem, smoothSpeed * Time.deltaTime);

    }
    void Limite()
    {
        if(transform.position.y > ymax)
        {
            transform.position = new Vector3(transform.position.x, ymax, -10); 
        }
        if (transform.position.y < -ymax)
        {
            transform.position = new Vector3(transform.position.x, -ymax, -10);
        }
    }
    
 
}
