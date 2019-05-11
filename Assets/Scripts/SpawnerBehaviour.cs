using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    private int sorteio;
    [SerializeField]
    private GameObject[] lixos;

    void Start()
    {
      InvokeRepeating("SpawnObstaculos", 0, 1.5f);
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
} 
  