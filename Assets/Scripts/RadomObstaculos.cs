using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomObstaculos : MonoBehaviour
{
    public float tempocorrido = 0;
    public float proximoSpawn;
    public GameObject[] lixos;
    public int sorteio;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {sorteio = Random.Range(0,2);
        if (Time.time >= tempocorrido)
        {
            tempocorrido = Time.time + proximoSpawn;
            Vector2 position = new Vector2(14, Random.Range(2, -4.89f));
            Instantiate(lixos[sorteio], position, Quaternion.identity);

        }
    }


} 
  