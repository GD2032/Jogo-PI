using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    //public float zoomSpeed ;
    //public float smoothSpeed = 30.0f;
    // public float minRange = 1.9f;
    //public float target;

    private float speedZoom;
    private float Exp = 2.23f;
    private Vector2 newPosition;
    private Vector2 target;
    private Camera camera;
    private float size;
    private float sizeAdd = 4f;
    private float sizeMin = 1f;
    private float speed;
    private float xmax = 2.3f;
    private float xmin = 0.3f; 
    private float ymax = 4.769569f;
    [SerializeField]
    private GameObject personagem;
    private float eixoY;
    private bool zoomQte;
    void Start()
    {

        camera = GetComponentInChildren<Camera>();
        speed = 6;
        newPosition = transform.position;
    }
    void Update()
    {
        //if (personagem.GetComponent<PlayerBehaviour>().PlayerAlive )
        //
            eixoY = Input.GetAxis("Vertical");
            transform.Translate(Vector3.up * eixoY * speed * Time.deltaTime);
            Limite();
        if (zoomQte)
        {
            if(camera.orthographicSize > 3f)
            {
                Zoom(8f, 1f);
            }
        }
        //}
       // Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, playerBehaviour.posicaoPersonagem, smoothSpeed * Time.deltaTime);
    }
    void Limite()
    {
        if(transform.position.y > ymax)
        {
            transform.position = new Vector3(transform.position.x, ymax, -10); 
        }
        if(transform.position.y < -ymax)
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
    public void Zoom(float speed, float speedZoom)
    {
        /* target = personagem.transform.position;
         size = target.x;
         size = Mathf.Max(size, target.y);
         transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
         camera.orthographicSize = Mathf.SmoothDamp(camera.orthographicSize, size, ref speedZoom, 4f);  */
        target = personagem.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        camera.orthographicSize = Mathf.Pow(0.5f,speedZoom);
        if(speedZoom >= 0)
        {
            speedZoom = 0.1f;
        }
        speedZoom -= 1f * Time.deltaTime;
        
    }
}
