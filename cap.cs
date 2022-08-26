using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cap : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "banana")
        {
            Debug.Log("test");
        }
    }

}
