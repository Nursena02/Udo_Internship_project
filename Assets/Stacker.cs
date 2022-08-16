using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Stackable"))
        {
            
            var newPosX =  transform.position.x + +collision.collider.bounds.extents.x * 3;
            collision.collider.transform.localPosition = new Vector3(newPosX, transform.position.y, transform.position.z);

            // Debug.Log(collision.collider.bounds.extents.z *2); 
        }
    }

    // {
    //     if (other.CompareTag("Stackable"))
    //     {
    //         other.transform.SetParent(transform);
    //        Debug.Log(other.bounds.extents.z *2); 
    //     }
    // }
}