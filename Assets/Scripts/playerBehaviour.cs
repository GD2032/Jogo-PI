using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerBehaviour : CountTime
{
    private int[] Vidas = new int[3] { 1, 1, 1 };
    [SerializeField]
    private Text pontuacao;
    private float Count;
    private GameObject sacola;
    private GameObject aguaViva;
    private GameObject camera;
    [SerializeField]
    private GameObject fundoPreto;
    [SerializeField]
    private GameObject fundoPreto2;
    private GameObject[] Coracao = new GameObject[3];
    private float contadorQte;
    private bool leftArrowEnabled;
    private bool rightArrowEnabled;

    private float animationF;
    private float animationProx;
    private float speed;
    private float opacidadeP;
    public float opacidadeRA;
    public float opacidadeLA;
    private static bool movimento;
    private float xmax = 9.43f;
    private float ymax = 9.04f;
    private float ymin;
    private GameObject laser;
    private GameObject boca;
    private float movimentoEixoX;
    private float movimentoEixoY;
    private float contador = 0;
    private float pontuacaoFood;
    private bool Qte;
    private bool pontuacaoEnable = true;
    [SerializeField]
    private Image leftArrow;
    [SerializeField]
    private Image rightArrow;
    [SerializeField]
    private Canvas canvas;
     [SerializeField]
    private GameObject gameOver;
    private bool instantiateQte = true;

    void Start()
    {
        startTime = Time.time;
        camera = GameObject.FindWithTag("MainCamera");
        speed = 8;
        leftArrowEnabled = true; 
        opacidadeP = 0;
        opacidadeRA = 0;
        opacidadeLA = 0;
        movimento = true;
        sacola = GameObject.FindWithTag("Sacola");
        aguaViva = GameObject.FindWithTag("Obstaculo");
        Coracao[0] = GameObject.FindWithTag("C1");
        Coracao[1] = GameObject.FindWithTag("C2");
        Coracao[2] = GameObject.FindWithTag("C3");
        leftArrow.color = new Color(leftArrow.color.r, leftArrow.color.g, leftArrow.color.b, opacidadeLA);
        rightArrow.color = new Color(rightArrow.color.r, rightArrow.color.g, rightArrow.color.b, opacidadeRA);
    }

    void Update()
    {
        actualTime = Tempo(startTime);
        Movimentacao();
        Limite();
        pontuacao.color = new Color(pontuacao.color.r, pontuacao.color.g, pontuacao.color.b, opacidadeP);
        if (actualTime >= 6f)
        {
            if (opacidadeP <= 1)
            {
                pontuacao.color = new Color(pontuacao.color.r, pontuacao.color.g, pontuacao.color.b, opacidadeP);
                opacidadeP += 0.1f;
            } 
            if (opacidadeP >= 0.1 && contador < 1)
            {
                 startTime = Time.time;
                 actualTime = Tempo(startTime);
                 Count = Mathf.Round(actualTime);
                 pontuacao.text = Count.ToString();
                 contador++;
            }    
        }
       
        if ( actualTime > animationF)
        {
            GetComponent<Animator>().SetBool("Comendo", false);
            GetComponent<Animator>().SetBool("Nadando", true);
            animationF = 0;
            animationProx = 0;
        }
        if (pontuacaoEnable)
        {
             Count = Mathf.Round(actualTime) + pontuacaoFood;
             pontuacao.text = Count.ToString();
        }
        if (Qte)
        {
            if (instantiateQte)
            {
                InstantiateArrows();
                leftArrow.color = new Color(leftArrow.color.r, leftArrow.color.g, leftArrow.color.b, opacidadeLA);
                rightArrow.color = new Color(rightArrow.color.r, rightArrow.color.g, rightArrow.color.b, opacidadeRA);
                //instanciar tempo *-*
            }
            else
            {
                bool instantiateQte = false;
            }
            if (leftArrowEnabled)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    opacidadeLA = 0.5f;
                    opacidadeRA = 1.0f;
                    contadorQte++;
                    print("samuel é gay");
                    rightArrowEnabled = true;
                    leftArrowEnabled = false;
                }
            } 
            if (rightArrowEnabled)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    opacidadeRA = 0.5f;
                    opacidadeLA = 1.0f;
                    contadorQte++;
                    leftArrowEnabled = true;
                    rightArrowEnabled = false;
                }
            }
            if (contadorQte >= 20)
            {
                Qte = false;
                pontuacaoEnable = true;
            }
            leftArrow.color = new Color(leftArrow.color.r, leftArrow.color.g, leftArrow.color.b, opacidadeLA);
            rightArrow.color = new Color(rightArrow.color.r, rightArrow.color.g, rightArrow.color.b, opacidadeRA);
        }
    }

    void Movimentacao()
    {
        movimentoEixoX = Input.GetAxis("Horizontal");
        movimentoEixoY = Input.GetAxis("Vertical");
        if (movimento)
        {
            transform.Translate(Vector3.right * movimentoEixoX * speed * Time.deltaTime, Space.World);
            transform.Translate(Vector3.up * movimentoEixoY * speed * Time.deltaTime, Space.World);
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
        if (colapse.tag == "Sacola")
        {
            for (int i = 0; i < 3; i++)
            {
                if (Vidas[i] == 1)
                {
                    contadorQte++;
                    Vidas[i] = 0;
                    // armazena uma referência ao SpriteRenderer no GameObject atual
                    SpriteRenderer opacidade = Coracao[i].transform.GetComponent<SpriteRenderer>();
                    // copia a propriedade da cor do SpriteRenderer
                    Color opac = opacidade.color;
                    // altera o valor alfa do opac (0 = invisível, 1 = totalmente opaco)
                    opac.a = 0.5f;
                    // altera a propriedade color do SpriteRenderer para corresponder à cópia com o valor alfa alterado
                    opacidade.color = opac;
        
                    if (Vidas[2] == 0)
                    {
                        Instantiate(fundoPreto);
                        StartCoroutine(contagemFadeOut());    
                    }
                    break;
                }
            }
        }
        if (colapse.tag == "Obstaculo")
        {
            pontuacaoFood += 10;
        }
        if (colapse.tag == "SacolaQte")
        {
            quickTimeEvent();
        }
    }
    public void animationEat()
    {
        GetComponent<Animator>().SetBool("Nadando", false);
        GetComponent<Animator>().SetBool("Comendo", true);
        animationProx = actualTime;
        animationF = animationProx + 0.5f;
    }
    public void quickTimeEvent()
    {
        movimento = false;
        camera.GetComponent<CameraBehaviour>().SetSpeed(0);
        camera.GetComponent<CameraBehaviour>().SetZoomQte(true);
        Qte = true;
        pontuacaoEnable = false;
        
        
    }
   IEnumerator contagemFadeOut()
    {
        yield return new WaitForSeconds(0.6f);
        Destroy(this.fundoPreto);
        Instantiate(this.fundoPreto2);
        Destroy(this.gameObject);
        StartCoroutine(TeladeGameOver());

    }
    public void InstantiateArrows()
    {
        leftArrow.color = new Color(leftArrow.color.r, leftArrow.color.g, leftArrow.color.b, 1);
        rightArrow.color = new Color(rightArrow.color.r, rightArrow.color.g, rightArrow.color.b, 0.5f);
    }
     IEnumerator TeladeGameOver()
    {
        gameOver.SetActive(true);
        yield return new WaitForSeconds(0.6f);
    }
}