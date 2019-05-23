using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearFish : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(1, 0) * Time.deltaTime* -4 ;
        if (transform.position.x < -10f)
        {
            Destroy(this.gameObject);
        }
    }
}
