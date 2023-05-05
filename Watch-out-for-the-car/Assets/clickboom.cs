using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickboom : MonoBehaviour
{

    public GameObject objectToSpawn; 
    public int count = 100;
    void OnMouseDown()
    {
      
        for(int x = 0; x <= count; x++)
        {
            GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            Debug.Log("게임 종료");
            Application.Quit();
        }
     
    }
  
}
