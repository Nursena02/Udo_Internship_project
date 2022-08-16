using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;

public class StackManager : MonoBehaviour
{

    public List<GameObject> items;

    public float lerpFactor = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        LerpStack();
    }


    private void LerpStack()
    {
        for (int i = 1; i < items.Count; i++)
        {
            var previousItem = items.ElementAt(i - 1);
            var currentItem = items.ElementAt(i);

            var previousItemX = previousItem.transform.position.y;
            var currentItemX = currentItem.transform.position.y;

            var newPreviousItemPos = new Vector3(0,previousItemX, 0);
            var newCurrentItemPos = new Vector3(0,currentItemX,  0);

            currentItem.transform.DOMoveX(previousItem.transform.position.x, Time.deltaTime * lerpFactor);
        }
    }
}
