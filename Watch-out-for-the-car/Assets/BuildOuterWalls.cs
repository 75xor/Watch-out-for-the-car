using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildOuterWalls : MonoBehaviour
{
    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        for(float x=-5.5f; x <= 5.5f; x+=0.5f)
        {
            GameObject blockobject = GameObject.Instantiate<GameObject>(block, new Vector3(x, 3f ,- 5.5f), Quaternion.identity);
            blockobject.transform.SetParent(transform,false);
            blockobject = GameObject.Instantiate<GameObject>(block, new Vector3(x, 3f, 5.5f), Quaternion.identity);
            blockobject.transform.SetParent(transform,false);
        }
   

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
