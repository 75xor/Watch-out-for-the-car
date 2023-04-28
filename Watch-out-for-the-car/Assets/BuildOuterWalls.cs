using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildOuterWalls : MonoBehaviour
{
    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        for(int x=-5; x <= 5; x++)
        {
            GameObject blockobject = GameObject.Instantiate<GameObject>(block, new Vector3(x, 1.5f ,- 5), Quaternion.identity);
            blockobject.transform.SetParent(transform,false);
            blockobject = GameObject.Instantiate<GameObject>(block, new Vector3(x, 1.5f, 5), Quaternion.identity);
            blockobject.transform.SetParent(transform,false);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
