using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class maymun_hareket : MonoBehaviour
{
    public GameObject maymun;
    private bool tap, swipeLeft, swipeRight;
    private bool isDraging;
    private Vector2 startTouch, swipeDelta;
    Animator m_Animator;
    void Start() => m_Animator = GetComponent<Animator>();

    // Update is called once per frame
    private Vector3 _mousePos;

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
       // {
            //_mousePos = Input.mousePosition;
            _mousePos = maymun.transform.position;
       // }
        if (Input.GetMouseButtonUp(0))
        {
            if (_mousePos.x < Input.mousePosition.x)
            {
                Debug.Log("Right");
                //Right
            }
            else if (_mousePos.x > Input.mousePosition.x)
            {
                Debug.Log("Left");
                //Left



                // calculate the distance
                swipeDelta = Vector2.zero;
                if (isDraging)
                {
                    if (Input.touches.Length > 0)
                    {
                        Vector2 startTouch1 = startTouch;
                        //swipeDelta = Input.mousePosition - startTouch1;
                    }
                }
                // DÝd we cross the endzoýne?
                if (swipeDelta.magnitude > 125)
                {
                    //which direction?
                    float x = swipeDelta.x;
                    float y = swipeDelta.y;
                    if (Mathf.Abs(x) > Mathf.Abs(y))
                    {
                        // left or right
                        if (x < 0)

                            m_Animator.SetTrigger("left");
                        else
                            m_Animator.SetTrigger("right");
                    }
                    Reset();
                }

            }
            void Reset()
            {
                startTouch = swipeDelta = Vector2.zero;
            }
        }
    }
    public Vector2 SwipeDelta => swipeDelta;
    public Vector2 SwipeLeft { get { return SwipeLeft; } }
    public Vector2 SwipeRight { get { return SwipeRight; } }

}