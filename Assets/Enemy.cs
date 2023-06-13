using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    float e_speed = 5;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * e_speed * Time.deltaTime);


        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Laser")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Player" && other.gameObject.TryGetComponent <Player>(out Player player))
        {
            player.Health();
        }
        Destroy(gameObject);
    }

   
}

