using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    //public float zoomSpeed ;
    //public float smoothSpeed = 30.0f;
    // public float minRange = 1.9f;
    //public float target;

    private Vector2 newPosition;
    private Vector2 target;
    private Camera camera;
    private float size;
    private float sizeAdd = 4f;
    private float sizeMin = 1f;
    private float speed;
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
             Zoom(4f, 1f);
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
        if (transform.position.y < -ymax)
        {
            transform.position = new Vector3(transform.position.x, -ymax, -10);
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

        target = personagem.transform.position;
        size = Mathf.Max(size, Mathf.Abs(target.x));
        size = Mathf.Max(size, Mathf.Abs(target.y));
        size += sizeAdd;
        size = Mathf.Max(size, sizeMin);
        speedZoom *= -1;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        camera.orthographicSize = camera.orthographicSize != sizeMin ? Mathf.SmoothDamp(camera.orthographicSize, size , ref speedZoom, 4f) : camera.orthographicSize;
        
    }
}
