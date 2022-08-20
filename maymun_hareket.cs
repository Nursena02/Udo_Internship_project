using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class maymun_hareket : MonoBehaviour
{
    //Vector3 right=new Vector3(-20f,0,0);
    //Vector3 temp = new Vector3(20f, 0, 0);
    public float maxHealth;
    public float health;
    public HealthBar healthBar;
    public GameObject monkey;
    private bool tap, swipeLeft, swipeRight, hanging;
    private bool isDraging;
    private Vector2 startTouch, swipeDelta;
    Animator m_Animator;
    public void TakeDamage()
    {
        health -= Mathf.Min(Random.value, health / 4f);
        healthBar.UpdateHealthBar();
    }
        void Start() => m_Animator = GetComponent<Animator>();

    // Update is called once per frame
    private Vector3 _mousePos;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TakeDamage();
            // _mousePos = Input.mousePosition;
            _mousePos = monkey.transform.position;
            startTouch = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            swipeDelta = Input.mousePosition - _mousePos;
            if (_mousePos.x < Input.mousePosition.x)
            {
                Debug.Log("Right");
                // monkey.transform.position-=temp;
                m_Animator.SetTrigger("right");
                //Right
                Reset();
            }
            else if (_mousePos.x > Input.mousePosition.x)
            {
                Debug.Log("Left");
                // monkey.transform.position += temp;
                m_Animator.SetTrigger("left");
                Reset();
                //Left

                

            }
            void Reset()
            {
                startTouch = swipeDelta = Vector3.zero;
            }
        }
    }

    public Vector2 SwipeDelta => swipeDelta;
    public Vector2 SwipeLeft { get { return SwipeLeft; } }
    public Vector2 SwipeRight { get { return SwipeRight; } }

}