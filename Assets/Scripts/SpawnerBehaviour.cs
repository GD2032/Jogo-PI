using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    private int sorteio;
 
    [SerializeField]
    private GameObject[] lixos;
    [SerializeField]
    private GameObject mar;
    [SerializeField]
    private GameObject[] fish;
    [SerializeField]
    private GameObject[] algas;
    [SerializeField]
    private GameObject[] Conchas;


    void Start()
    {
      InvokeRepeating("BigFishSpawn", 4f, 5f);
      InvokeRepeating("SeaSpawn", 0f ,1.5f);
      InvokeRepeating("SpawnObstaculos", 0f, 1.5f);
      InvokeRepeating("SpawnObstaculos", 2f, 1.5f);
      InvokeRepeating("SpawnObstaculos", 4f, 1.5f);
      InvokeRepeating("CoraisSpawn", 0f, 0.5f);
      InvokeRepeating("CoralVerdeSpawn", 1.25f, 2.5f);
      InvokeRepeating("ConchaSpawn", 1.4f, 2.5f);
    }
    void Update()
    {
    }
    void SpawnObstaculos()
    {
        sorteio = Random.Range(0, 4);
        Vector2 position = new Vector2(14, Random.Range(2, -6.89f));
        Instantiate(lixos[sorteio], position, Quaternion.identity);
    }
    void SeaSpawn()
    {
        Instantiate(mar,new Vector2(7.5f,-0.04f), Quaternion.identity);
    }
    void BigFishSpawn ()
    {
        sorteio = Random.Range(0,4);
        Vector2 position = new Vector2(10, Random.Range(9f, -9f));
        Instantiate(fish[sorteio], position, Quaternion.identity);
         Instantiate(algas[3], new Vector2(10f, -9f), Quaternion.identity);

    }
    void CoraisSpawn()
    {
        sorteio = Random.Range(0, 7);
        Vector2 position = new Vector2(10f, -9f);
        Instantiate(algas[sorteio], position, Quaternion.identity);
    }
    void CoralVerdeSpawn()
    {
        Vector2 position = new Vector2(10f, -8.5f);
        Instantiate(algas[5], position, Quaternion.identity);
        Instantiate(algas[5], new Vector2 ( 14f,-9.7f), Quaternion.identity);

    }
    void ConchaSpawn()
    {
        sorteio = Random.Range(0, 2);
        Vector2 position = new Vector2(10f, -9.7f);
        Instantiate(Conchas[sorteio], position, Quaternion.identity);
    }
} 
  