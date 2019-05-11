using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private int[] Vidas = new int[3] { 1, 1, 1 };
    private GameObject sacola;
    private GameObject aguaViva;

    private float speed;
    private static bool movimento;
    private bool playerAlive;
    private static float posicaoPersonagem;

    private float xmax = 9.43f;
    private float ymax = 9.04f;
    private float ymin;
    private GameObject laser;
    private GameObject boca;
    private float movimentoEixoX;
    private float movimentoEixoY;

    void Start()
    {

        speed = 8;
        playerAlive = true;
        movimento = true;
        sacola = GameObject.FindWithTag("Sacola");
        aguaViva = GameObject.FindWithTag("Obstaculo");
    }

    void Update()
    {
        Movimentacao();
        Limite();
    }

    void Movimentacao()
    {
        movimentoEixoX = Input.GetAxis("Horizontal");
        movimentoEixoY = Input.GetAxis("Vertical");
        if (movimento)
        {
            transform.Translate(Vector3.right * movimentoEixoX * speed * Time.deltaTime);
            transform.Translate(Vector3.up * movimentoEixoY * speed * Time.deltaTime);
        }
    }
    void Limite()
    {
        if (transform.position.x > xmax)
        {
            transform.position = new Vector3(xmax, transform.position.y);
        }
        else if (transform.position.x < -xmax)
        {
            transform.position = new Vector3(-xmax, transform.position.y);
        }
        if (transform.position.y > ymax)
        {
            transform.position = new Vector3(transform.position.x, ymax);
        }
        if (transform.position.y < -ymax)
        {
            transform.position = new Vector3(transform.position.x, -ymax);
        }
    }
    void OnTriggerEnter2D(Collider2D colapse)
    {

        //if (colapse.tag == "qte")
        //{
        //    posicaoPersonagem = transform.position.x;
        //    speed = 0;


        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Instantiate(laser, boca.GetComponent<Transform>().position, Quaternion.identity);
        //}
        //}
        if (colapse.tag == "Sacola")
        {
            for (int i = 2; i > -1; i--)
            {
                if (Vidas[i] == 1)
                {
                    Vidas[i] = 0;
                    break;
                }
                if (Vidas[0] == 0)
                {
                    Destroy(this.gameObject);
                    playerAlive = false;
                }
            }
        }
        if (colapse.tag == "Obstaculo")
        {

        }
    }
      public bool PlayerAlive{ get; set;}
}