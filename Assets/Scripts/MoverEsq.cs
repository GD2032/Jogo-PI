using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEsq : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-6, 0);
        //new Vector3 = (transform.position,po)
    }
}
