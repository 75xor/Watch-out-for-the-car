using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMove : MonoBehaviour
{
    public Vector3 direction = Vector3.up; // �̵� ����
    public float distance = 10f; // �̵� �Ÿ�
    public float speed = 2f; // �̵� �ӵ�

    private Vector3 startingPosition; // ���� ��ġ
    private float t; // �̵� �ð�

    private void Start()
    {
        startingPosition = transform.position;
    }

    private void Update()
    {
        t += Time.deltaTime * speed;
        transform.position = startingPosition + direction * Mathf.PingPong(t, distance);
      
    }
}
