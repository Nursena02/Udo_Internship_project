using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[ ]prefabs;
   public GameObject zemin;

    int zpos;

    // Update is called once per frame
    void Start()
    {
        int randomnum;
        for(int i=0;i<10;i++)
        {
            randomnum = Random.Range(0, 3);
            zemin = prefabs[randomnum];
            zpos += 3;
            instantiate();
        }

    }
    public void instantiate()
    {
        zemin = Instantiate(zemin, new Vector3(0, 0, zpos), zemin.transform.rotation);
    }

}
