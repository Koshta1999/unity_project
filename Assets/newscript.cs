using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newscript : MonoBehaviour
{
    int speed = 5;
    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Scale(2, 2, 2);
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if(transform.position.y >= 5)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        
    }

    void LateUpdate()
    {
        
    }

    
}
