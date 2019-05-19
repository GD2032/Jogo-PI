using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0) * Time.deltaTime * -9;
        if (transform.position.x <= -7.8f)
        {
            Destroy(this.gameObject);
        }
    }
}
