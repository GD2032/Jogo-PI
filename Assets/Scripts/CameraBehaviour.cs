using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    //public float zoomSpeed ;
    //public float smoothSpeed = 30.0f;
   // public float minRange = 1.9f;
    //public float target;
 
    private float speed;
    private float ymax = 4.769569f;
    [SerializeField]
    private GameObject personagem;
    private float eixoY;
    void Start()
    {
        speed = 6;
    }
    void Update()
    {
        //if (personagem.GetComponent<PlayerBehaviour>().PlayerAlive )
        //{
            eixoY = Input.GetAxis("Vertical");
            transform.Translate(Vector3.up * eixoY * speed * Time.deltaTime);
            Limite();
        //}
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
