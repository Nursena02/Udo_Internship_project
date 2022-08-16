using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe : MonoBehaviour
{
    private bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
    private bool isDraging;
    private Vector2 startTouch, swipeDelta;
   private void Update()
    {
        
        #region Mobile Inputs
        if(Input.touches.Length> 0)
        {
            if(Input.touches[0].phase == TouchPhase.Began)
            {
                isDraging = true;
                tap = true;
                startTouch = Input.touches[0].position;
            }
            else if(Input.touches[0].phase ==TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isDraging = false;
               Reset();
            }
        }
        #endregion
        // calculate the distance
        swipeDelta = Vector2.zero;
        if(isDraging)
        {
            if (Input.touches.Length > 0)
                swipeDelta = Input.touches[0].position - startTouch;
        }
        // DÝd we cross the endzoýne?
        if(swipeDelta.magnitude > 125)
        {
            //which direction?
            float x = swipeDelta.x;
            float y = swipeDelta.y;
            if (Mathf.Abs(x) > Mathf.Abs(y))
             {
                // left or right
                if (x < 0)
                    swipeLeft = true;
                else
                    swipeRight = true;
            }
                   else
                    {
                // up or down
                if (y < 0)
                    swipeDown = true;
                else
                    swipeUp = true;
                     }
            Reset();
            }
        }
    
    private void Reset()
    {
        startTouch = swipeDelta = Vector2.zero;
    }
    public Vector2 SwipeDelta { get { return swipeDelta; } }
    public Vector2 SwipeLeft { get { return SwipeLeft; } }
    public Vector2 SwipeRight { get { return SwipeRight; } }
    public Vector2 SwipeUp { get { return SwipeUp; } }
    public Vector2 SwipeDown{ get { return SwipeDown; } }
}
    

   

