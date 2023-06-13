using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField]
     public float m_playerspeed;

    
    [SerializeField]
    public float m_playerspeed1;

    public GameObject prefab;
    

    public float firerate = 0.1f;
    private float fireable;

    GameObject contain;
    GameObject Obj;
    int heal = 3;
   


    
    void Awake()
    {
        //transform.position = new Vector3(0,0,0);
    }
    void Start()
    {
        transform.position = Vector3.zero;
        Obj = new GameObject("Laser container");
        

      
       
    }

    // Update is called once per frame
    void Update()
    {

        Fire();
        Movement();

    }

    void LateUpdate()
    {
        
    }

    public void Fire()
    {

        if (Input.GetKeyDown(KeyCode.Space) && fireable < Time.time)
        {
             Instantiate(prefab, this.gameObject.transform.position, Quaternion.identity,  Obj.transform);
            fireable = firerate + Time.time;
            Debug.Log("Error");
            //fired.transform.SetParent(Obj.transform);
        }
       
    }

    public void Movement()
    {


        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, 0) * m_playerspeed * Time.deltaTime);
        transform.Translate(new Vector3(0, Input.GetAxis("Vertical"), 0) * m_playerspeed1 * Time.deltaTime);

        if (transform.position.y > 8)
        {
            transform.position = new Vector3(transform.position.x, 8, transform.position.z);
            
        }

        if (transform.position.y <-8)
        {
            transform.position = new Vector3(transform.position.x, -8, transform.position.z);
        }

        if (transform.position.x > 8)
        {
            transform.position = new Vector3(-8, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -8)
        {
            transform.position = new Vector3(8, transform.position.y, transform.position.z);   
        }
    }

    public void Health()
    {
            heal--;
        Debug.Log(" player health = " + heal);
        if (heal == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
