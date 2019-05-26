using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medusaBehaviour : MonoBehaviour
{
    float aceleracao;
    // Start is called before the first frame update
    void Start()
    {
        aceleracao = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(2f, 0) * aceleracao * -1 * Time.deltaTime;
        aceleracao -= 0.02f;
        if (aceleracao <= 0.1)
        {
            aceleracao = 1.4f;
        }
    }
}
