using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickboom : MonoBehaviour
{

    public GameObject objectToSpawn; // 생성할 오브젝트 프리팹
    public int count = 100;
    void OnMouseDown()
    {
        // 마우스 클릭이 감지되었을 때 실행되는 함수

        // 오브젝트를 생성하고, 생성된 오브젝트의 위치를 클릭한 큐브의 위치로 설정
        for(int x = 0; x <= count; x++)
        {
            GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
     
    }
  
}
