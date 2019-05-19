using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    private int sorteio;
    private int rnd;
 
    [SerializeField]
    private GameObject[] lixos;
    [SerializeField]
    private GameObject mar;
    [SerializeField]
    private GameObject[] fish;

    void Start()
    {
      InvokeRepeating("BigFishSpawn", 4f, 5f);
      InvokeRepeating("SeaSpawn", 0f ,1.5f);
      InvokeRepeating("SpawnObstaculos", 0f, 1.5f);
      InvokeRepeating("SpawnObstaculos", 2f, 1.5f);
      InvokeRepeating("SpawnObstaculos", 4f, 1.5f);

    }
    void Update()
    {
    }
    void SpawnObstaculos()
    {
        sorteio = Random.Range(0, 2);
        Vector2 position = new Vector2(14, Random.Range(2, -6.89f));
        Instantiate(lixos[sorteio], position, Quaternion.identity);
    }
    void SeaSpawn()
    {
        Instantiate(mar,new Vector2(7.5f,-0.04f), Quaternion.identity);
    }
    void BigFishSpawn ()
    {
         rnd = Random.Range(0,3);
        Vector2 position = new Vector2(10, Random.Range(9f, -9f));
        Instantiate(fish[rnd], position, Quaternion.identity);

    }
} 
  