using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaBehavior : CountTime
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-9, 0) * Time.deltaTime;
        if (transform.position.x <= -17)
        {
            Destroy(this.gameObject);
        }
    }
}
