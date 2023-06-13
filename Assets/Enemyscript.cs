using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour
{
    private float e_fireable;
    private float e_firerate;
    public GameObject prefab1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (e_fireable < Time.time)
        {

            Instantiate(prefab1, new Vector3(Random.Range(-12, 12), 8, 0), Quaternion.identity, this.transform);
            e_fireable = Random.Range(1, 5) + Time.time;
        }
    }
}
