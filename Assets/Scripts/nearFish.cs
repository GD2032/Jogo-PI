using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearFish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0) * Time.deltaTime* -4 ;
        if (transform.position.x < -10f)
        {
            Destroy(this.gameObject);
        }
    }
}
