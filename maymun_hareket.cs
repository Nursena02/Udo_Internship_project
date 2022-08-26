using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class maymun_hareket : MonoBehaviour
{
    public GameObject lost_panel;
    public float maxHealth;
    public float health;
    public HealthBar healthBar;
    public GameObject monkey;
    private bool  swipeLeft, swipeRight, hanging,falling;
    private Vector2 startTouch, swipeDelta;
    Animator m_Animator;
    
    public void TakeDamage()
    {
        health += 5;
        healthBar.UpdateHealthBar();
        Debug.Log("update");
        
    }
    public void TakeDamage2()
    {
        health -= 20;
        healthBar.UpdateHealthBar();
        Debug.Log("update2");
    }
    
    void Start() => m_Animator = GetComponent<Animator>();
    
    // Update is called once per frame
    private Vector3 _mousePos;

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
             _mousePos = Input.mousePosition;
           
        }
       else if (Input.GetMouseButtonUp(0))
        {
           
            if (_mousePos.x < Input.mousePosition.x)
            {
               
                
                Debug.Log("Right");
              
                m_Animator.Play("right",0);
                
            
            }

            else if (_mousePos.x > Input.mousePosition.x)
            {
               
                Debug.Log("Left");
               m_Animator.Play("left", 0);

                //Left

            }

          }
        if (health <= 0)
        {
            Debug.Log("falling");
            m_Animator.Play("falling");
            lost_panel.SetActive(true);
            Invoke("turn_main",5);
        }
       
    }
    public void turn_main()
    {
        SceneManager.LoadScene(0);
    }
    void OnTriggerEnter(Collider other)
    {
        if (health > 0)
        {
            if (other.gameObject.tag == "banana")
            {
                other.gameObject.SetActive(false);
                TakeDamage();
            }


            if (other.gameObject.tag == "black_banana")
            {
                other.gameObject.SetActive(false);
                TakeDamage2();
            }
        }
    }



}
        