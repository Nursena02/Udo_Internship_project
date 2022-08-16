using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleController : MonoBehaviour
{
    public float lateralSpeed;
    public float forwardSpeed = 10f;
    
       
       //Update is called once per frame
       private void Update()
       {
           float sideMovement = Input.GetAxis("Horizontal");
           transform.Translate(sideMovement * lateralSpeed *Time.deltaTime ,0, forwardSpeed*Time.deltaTime);
       }
}
