using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMove : MonoBehaviour
{
    public Vector3 direction = Vector3.up; // 이동 방향
    public float distance = 10f; // 이동 거리
    public float speed = 2f; // 이동 속도

    private Vector3 startingPosition; // 시작 위치
    private float t; // 이동 시간

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
