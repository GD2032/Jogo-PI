using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : CountTime
{

    //public float zoomSpeed ;
    //public float smoothSpeed = 30.0f;
    // public float minRange = 1.9f;
    //public float target;

    private float força;
    private float speedZoom;
    private bool enterZoom;
    private Vector3 target;
    private Camera camera;
    private float size;
    private float speed;
    private float xmax = 2.3f;
    private float xmin = 0.3f;
    private float ymax = 4.769569f;
    [SerializeField]
    private GameObject personagem;
    private float eixoY;
    private bool zoomQte;
    private float percentageSpeed;
    private bool startScene;
    void Start()
    {
        percentageSpeed = 1;
        enterZoom = true;
        camera = GetComponentInChildren<Camera>();
        camera.orthographicSize = 0f;
        speed = 6;
        startScene = true;
    }
    void Update()
    {
        Tempo(startTime);
        //if (personagem.GetComponent<PlayerBehaviour>().PlayerAlive )
        //
        if (startScene && actualTime > 3.8f)
        {
            Zoom(0.2f, 5f,false, false);
            if (camera.orthographicSize >= 5)
            {
                startScene = false;
            }
        }
        eixoY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * eixoY * speed * Time.deltaTime);
        Limite();
        if (zoomQte)
        {
            Zoom(0.5f, 2.5f, speed: 4f);
        }
        //}
        // Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, playerBehaviour.posicaoPersonagem, smoothSpeed * Time.deltaTime);
    }
    void Limite()
    {
        if (transform.position.y > ymax)
        {
            transform.position = new Vector3(transform.position.x, ymax, -10);
        }
        if (transform.position.y < -ymax)
        {
            transform.position = new Vector3(transform.position.x, -ymax, -10);
        }
        if (transform.position.x > xmax)
        {
            transform.position = new Vector3(xmax, transform.position.y, -10);
        }
        if (transform.position.x < xmin)
        {
            transform.position = new Vector3(xmin, transform.position.y, -10);
        }

    }
    public void SetSpeed(float newSpeed)
    {
        this.speed = newSpeed;
    }
    public void SetZoomQte(bool condition)
    {
        this.zoomQte = condition;
    }
    public void Zoom(float speedZoom, float limite, bool seguirPersonagem = true, bool zoomInside = true, bool enterZoom = true, float speed = 0f)
    {
        if (seguirPersonagem)
        {
            target = personagem.transform.position;
            camera.transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
        if (enterZoom)
        { 
            if (zoomInside ? camera.orthographicSize >= limite : camera.orthographicSize <= limite)
            {
                força = speedZoom * percentageSpeed;
                if (zoomInside)
                {
                     camera.orthographicSize -= Time.deltaTime * força;
                }
                else
                {
                     camera.orthographicSize += Time.deltaTime * força;
                }
                percentageSpeed += 0.1f;
            }
            else
            {
                enterZoom = false;
            }
            if (percentageSpeed <= 0)
            {
                percentageSpeed = 0.1f;
            }
        }
    }
}

