using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer1: MonoBehaviour
{


    public static bool isActive = false; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);

        isActive = true; 
    }


    //void OnCollisionEnter2D(Collision2D other)
    //{
    //    Debug.Log(other.gameObject.name);
    //}

}
