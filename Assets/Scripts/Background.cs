using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private float movespeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * movespeed * Time.deltaTime;
        if (transform.position.y < -10)
        {
            transform.position += new Vector3(0, 20f, 0);
        }
    }
}
