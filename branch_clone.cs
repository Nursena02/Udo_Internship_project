using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class branch_clone : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject[] array;
    public GameObject branch;
    public GameObject branch2;
   // public Rigidbody branch;
    int zpos;
    float x = 0;

    // Update is called once per frame
    
    void Start()
    {
       // int randomnum;
        for (int i = 0; i < 20; i++)
        {
           // randomnum = Random.Range(0,array.Length);
            // prefab[randomnum] = dal;
            zpos += 10;

            Spawner();
        }

    }


    void Spawner()
    {
 
        Instantiate(branch, new Vector3(transform.position.x, transform.position.y, transform.position.z+ zpos), branch.transform.rotation);
        Instantiate(branch2, new Vector3(transform.position.x, transform.position.y, transform.position.z + zpos), branch2.transform.rotation);

    }

}

