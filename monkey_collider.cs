
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monkeycollider : MonoBehaviour
{
    int hangingHash = Animator.StringToHash("hanging");
    int fallingHash = Animator.StringToHash("falling");
    int leftstateHash = Animator.StringToHash("left");
    int rightstateHash = Animator.StringToHash("right");
    [SerializeField] private GameObject monkey;
    Animator m_Animator;
    [SerializeField] private Transform branch;

    // Start is called before the first frame update
    void Awake()
    {
        m_Animator = GetComponent<Animator>();
    }
        private Vector3 _mousePos;
   private object m_animator;

    /* private void OnCollisionEnter(Collision collision)
     {
         monkey contact = collision.contacts[0];

     }
    */
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "{branch}")
        {
            m_Animator.SetTrigger("hangingHash");
        }
    }
    /*void Update()
    {
        _mousePos = monkey.transform.position;

    }
    */

}


