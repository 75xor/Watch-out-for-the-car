using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickboom : MonoBehaviour
{

    public GameObject objectToSpawn; // ������ ������Ʈ ������
    public int count = 100;
    void OnMouseDown()
    {
        // ���콺 Ŭ���� �����Ǿ��� �� ����Ǵ� �Լ�

        // ������Ʈ�� �����ϰ�, ������ ������Ʈ�� ��ġ�� Ŭ���� ť���� ��ġ�� ����
        for(int x = 0; x <= count; x++)
        {
            GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
     
    }
  
}
